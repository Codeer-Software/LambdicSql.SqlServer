using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Linq;
using System.Data.SqlClient;
using Dapper;
using System.Drawing;
using Newtonsoft.Json;
using System.IO;

namespace SystemtableMaker
{
    public partial class MainForm : Form
    {
        string _path;

        public MainForm()
        {
            InitializeComponent();
        }

        void ButtonSaveClick(object sender, EventArgs e)
        {
            using (var dlg = new SaveFileDialog())
            {
                if (dlg.ShowDialog() == DialogResult.OK)
                {
                    File.WriteAllText(dlg.FileName, JsonConvert.SerializeObject(_listBox.Items.Cast<ClassInfo>().ToArray()));
                    _path = dlg.FileName;
                }
            }
        }

        void ButtonLoadClick(object sender, EventArgs e)
        {
            using (var dlg = new OpenFileDialog())
            {
                if (dlg.ShowDialog() == DialogResult.OK)
                {
                    var text = File.ReadAllText(dlg.FileName);
                    var items = JsonConvert.DeserializeObject<ClassInfo[]>(text);
                    _listBox.Items.Clear();
                    _listBox.Items.AddRange(items);
                    if (0 < _listBox.Items.Count)
                    {
                        _listBox.SelectedIndex = 0;
                    }
                    _path = dlg.FileName;
                }
            }
        }

        void ButtonAddClick(object sender, EventArgs e)
        {
            var item = GetClassInfo(_url.Text, _input.Lines);
            if (item != null)
            {
                _listBox.Items.Add(item);
                _listBox.SelectedIndex = _listBox.Items.Count - 1;
            }
            _url.Text = string.Empty;
            _input.Text = string.Empty;

            if (!string.IsNullOrEmpty(_path))
            {
                File.WriteAllText(_path, JsonConvert.SerializeObject(_listBox.Items.Cast<ClassInfo>().ToArray()));
            }
        }

        void ButtonGenClick(object sender, EventArgs e)
        {
            var classText = string.Empty;
            var gen = new List<string>();

            var dic = new Dictionary<string, string>();

            foreach (var x in _listBox.Items.Cast<ClassInfo>())
            {
                if (gen.Contains(x.Name)) continue;
                classText += GenerateClassDefine(x);
                classText += (Environment.NewLine + Environment.NewLine);
                var prop = GeneratePropertyDefine(x);
                dic[prop.Item1] = dic.TryGet(prop.Item1) + prop.Item2 + Environment.NewLine + Environment.NewLine;
                gen.Add(x.Name);
            }

            {
                var form = new Form();
                var text = new TextBox { Multiline = true, Text = classText, Dock = DockStyle.Fill };
                form.Controls.Add(text);
                form.Show(this);
            }
            {
                var propertyText = string.Join(Environment.NewLine + Environment.NewLine + Environment.NewLine + Environment.NewLine,
                    dic.Select(x => x.Value));
                var form = new Form();
                var text = new TextBox { Multiline = true, Text = propertyText, Dock = DockStyle.Fill };
                form.Controls.Add(text);
                form.Show(this);
            }
        }

        void ButtonDeleteClick(object sender, EventArgs e)
        {
            if (_listBox.SelectedIndex == -1) return;
            _listBox.Items.RemoveAt(_listBox.SelectedIndex);
        }

        void ListBoxSelectedIndexChanged(object sender, EventArgs e)
        {
            if (_listBox.SelectedIndex == -1)
            {
                _classDefine.Text = string.Empty;
                return;
            }
            var classInfo = _listBox.SelectedItem as ClassInfo;
            _classDefine.Text = GenerateClassDefine(classInfo);
            _classDefine.ForeColor = classInfo.Todo ? Color.Red : Color.Black;
        }

        static ClassInfo GetClassInfo(string url, string[] texts)
        {
            try
            {
                texts = texts.Where(e => !string.IsNullOrEmpty(e)).ToArray();
                int index = -1;
                for (int i = 0; i < texts.Length; i++)
                {
                    if ((texts[i].Trim() == "Column name	Data type	Description") ||
                        (texts[i].Trim() == "Column name	Data type	Description and version-specific information"))
                    {
                        index = i;
                        break;
                    }
                }
                return new ClassInfo
                {
                    Url = url,
                    Name = GetName(texts[0], out var todo),
                    Todo = todo,
                    Properties = GetProperies(texts.Skip(index + 1).ToArray())
                };
            }
            catch { }
            return null;
        }

        static PropertyInfo[] GetProperies(string[] src)
        {
            var items = new List<PropertyInfo>();
            foreach (var e in src)
            {
                var sp = e.Split(new[] { '\t' }, StringSplitOptions.RemoveEmptyEntries);
                if (sp.Length != 3) continue;
                items.Add(new PropertyInfo
                {
                    Name = sp[0],
                    Type = sp[1]
                });
            }
            return items.ToArray();
        }

        static string GetName(string src, out bool todo)
        {
            var name = src.Replace("(Transact-SQL)", string.Empty).Trim();
            todo = true;
            var index = name.LastIndexOf("-");
            if (index != -1)
            {
                name = name.Substring(index + 1).Trim();
            }

            foreach (var e in new[] { string.Empty, "sys.", "msdb.", "msdb.dbo." })
            {
                try
                {
                    using (var con = new SqlConnection("Data Source=DESKTOP-I7CAVT9;Initial Catalog=LambdicSqlTest;User ID=sa;Password=codeer;"))
                    {
                        var newName = e + name;
                        con.Query("select * from " + newName).ToArray();
                        name = newName;
                        todo = false;
                    }
                    break;
                }
                catch { }
            }

            return name;
        }

        string GenerateClassDefine(ClassInfo info)
        {
            var lines = new List<string>();
            if (info.Todo)
            {
                lines.Add("//TODO can't use.");
            }
            lines.Add("/// <summary>");
            lines.Add("/// " + info.Url);
            lines.Add("/// </summary>");

            lines.Add("public class " + info.Name.ClassDefineName());
            lines.Add("{");

            bool first = true;
            foreach (var e in info.Properties)
            {
                if (!first)
                {
                    lines.Add(string.Empty);
                }
                first = false;
                lines.Add("    /// <summary>");
                lines.Add("    /// " + e.Name);
                lines.Add("    /// </summary>");
                lines.Add("    public " + e.Type.ToCspType() + " " + e.Name.ToCspName() + " { get; set; }");
            }
            lines.Add("}");
            return string.Join(Environment.NewLine, lines);
        }

        Tuple<string, string> GeneratePropertyDefine(ClassInfo info)
        {
            var lines = new List<string>();

            if (info.Todo)
            {
                lines.Add("//TODO can't use.");
            }
            lines.Add("/// <summary>");
            lines.Add("/// " + info.Url);
            lines.Add("/// " + info.Name);
            lines.Add("/// </summary>");
            lines.Add("[MemberTableConverter(Name = \""+ info.Name + "\")]");

            string propName = info.Name.LastName().ToCspName();
            lines.Add("public " + info.Name.ClassDefineName() + " " + propName + " => throw new InvalitContextException(nameof(" + propName + "));");
            return new Tuple<string, string>(info.Name.FirstNameEx(), string.Join(Environment.NewLine, lines));
        }
    }

    public static class InfoUtiles
    {
        public static string TryGet(this Dictionary<string, string> dic, string key)
            => dic.TryGetValue(key, out var value) ? value : string.Empty;

        public static string Add(this string src, string addText)
            => string.IsNullOrEmpty(src) ? addText : src + addText;

        public static string ToCspName(this string name)
            => name[0].ToString().ToUpper() + name.Substring(1);

        public static string ToCspType(this string type)
        {
            type = type.ToLower();
            switch (type)
            {
                case "smallint": return "short";
                case "int": return "int";
                case "bigint": return "long";
                case "tinyint": return "byte";
                case "tinyint not null": return "byte";
                case "bit": return "bool";
                case "uniqueidentifier": return "object";
                case "sysname": return "string";
                case "datetime": return "DateTime";

                case "image": return "byte[]";

                case "smallint null": return "short?";
                case "int null": return "int?";
                case "tinyint null": return "byte?";
                case "bit null": return "bool?";
                case "numeric null": return "decimal?";
                case "sql_variant": return "object";
                case "float": return "double";
                case "real": return "double";
                case "timestamp": return "TimeSpan";
                case "decimal": return "decimal";
                case "variable": return "object";
                case "xml": return "string";
            }
            if (type.Contains("binary")) return "byte[]";
            if (type.Contains("text")) return "byte[]";
            if (type.Contains("char")) return "string";
            if (type.Contains("numeric")) return "decimal";
            if (type.Contains("float")) return "double";
            if (type.Contains("smalldatetime")) return "DateTime";
            throw new NotSupportedException();
        }

        public static string ClassDefineName(this string name)
            => "Table_" + name.Replace(".", "_");

        public static string FirstNameEx(this string name)
        {
            var sp = name.Split(new[] { '.' }, StringSplitOptions.RemoveEmptyEntries);
            return sp.Count() ==1 ? string.Empty : sp.First();
        }

        public static string LastName(this string name)
        {
            var sp = name.Split(new[] { '.' }, StringSplitOptions.RemoveEmptyEntries);
            return sp.Last();
        }
    }


    public class PropertyInfo
    {
        public string Type { get; set; }
        public string Name { get; set; }
    }

    public class ClassInfo
    {
        public string Url { get; set; }
        public bool Todo { get; set; }
        public string Name { get; set; }
        public PropertyInfo[] Properties { get; set; }

        public override string ToString()
            => Todo ? "(TODO)" + Name : Name;
    }
}
