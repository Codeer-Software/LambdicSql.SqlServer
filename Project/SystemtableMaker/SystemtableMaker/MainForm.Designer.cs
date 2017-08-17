namespace SystemtableMaker
{
    partial class MainForm
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージ リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this._input = new System.Windows.Forms.TextBox();
            this._buttonAdd = new System.Windows.Forms.Button();
            this._listBox = new System.Windows.Forms.ListBox();
            this._classDefine = new System.Windows.Forms.TextBox();
            this._buttonSave = new System.Windows.Forms.Button();
            this._buttonLoad = new System.Windows.Forms.Button();
            this._buttonGen = new System.Windows.Forms.Button();
            this._buttonDelete = new System.Windows.Forms.Button();
            this._url = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // _input
            // 
            this._input.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this._input.Location = new System.Drawing.Point(12, 72);
            this._input.Multiline = true;
            this._input.Name = "_input";
            this._input.Size = new System.Drawing.Size(1003, 69);
            this._input.TabIndex = 0;
            // 
            // _buttonAdd
            // 
            this._buttonAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this._buttonAdd.Location = new System.Drawing.Point(1021, 118);
            this._buttonAdd.Name = "_buttonAdd";
            this._buttonAdd.Size = new System.Drawing.Size(75, 23);
            this._buttonAdd.TabIndex = 1;
            this._buttonAdd.Text = "Add";
            this._buttonAdd.UseVisualStyleBackColor = true;
            this._buttonAdd.Click += new System.EventHandler(this.ButtonAddClick);
            // 
            // _listBox
            // 
            this._listBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this._listBox.FormattingEnabled = true;
            this._listBox.ItemHeight = 12;
            this._listBox.Location = new System.Drawing.Point(12, 147);
            this._listBox.Name = "_listBox";
            this._listBox.Size = new System.Drawing.Size(222, 280);
            this._listBox.TabIndex = 2;
            this._listBox.SelectedIndexChanged += new System.EventHandler(this.ListBoxSelectedIndexChanged);
            // 
            // _classDefine
            // 
            this._classDefine.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this._classDefine.BackColor = System.Drawing.SystemColors.Window;
            this._classDefine.Location = new System.Drawing.Point(240, 147);
            this._classDefine.Multiline = true;
            this._classDefine.Name = "_classDefine";
            this._classDefine.ReadOnly = true;
            this._classDefine.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this._classDefine.Size = new System.Drawing.Size(856, 315);
            this._classDefine.TabIndex = 3;
            this._classDefine.WordWrap = false;
            // 
            // _buttonSave
            // 
            this._buttonSave.Location = new System.Drawing.Point(12, 13);
            this._buttonSave.Name = "_buttonSave";
            this._buttonSave.Size = new System.Drawing.Size(75, 23);
            this._buttonSave.TabIndex = 4;
            this._buttonSave.Text = "Save";
            this._buttonSave.UseVisualStyleBackColor = true;
            this._buttonSave.Click += new System.EventHandler(this.ButtonSaveClick);
            // 
            // _buttonLoad
            // 
            this._buttonLoad.Location = new System.Drawing.Point(93, 13);
            this._buttonLoad.Name = "_buttonLoad";
            this._buttonLoad.Size = new System.Drawing.Size(75, 23);
            this._buttonLoad.TabIndex = 5;
            this._buttonLoad.Text = "Load";
            this._buttonLoad.UseVisualStyleBackColor = true;
            this._buttonLoad.Click += new System.EventHandler(this.ButtonLoadClick);
            // 
            // _buttonGen
            // 
            this._buttonGen.Location = new System.Drawing.Point(174, 12);
            this._buttonGen.Name = "_buttonGen";
            this._buttonGen.Size = new System.Drawing.Size(75, 23);
            this._buttonGen.TabIndex = 6;
            this._buttonGen.Text = "Generate";
            this._buttonGen.UseVisualStyleBackColor = true;
            this._buttonGen.Click += new System.EventHandler(this.ButtonGenClick);
            // 
            // _buttonDelete
            // 
            this._buttonDelete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this._buttonDelete.Location = new System.Drawing.Point(12, 432);
            this._buttonDelete.Name = "_buttonDelete";
            this._buttonDelete.Size = new System.Drawing.Size(222, 23);
            this._buttonDelete.TabIndex = 7;
            this._buttonDelete.Text = "Delete";
            this._buttonDelete.UseVisualStyleBackColor = true;
            this._buttonDelete.Click += new System.EventHandler(this.ButtonDeleteClick);
            // 
            // _url
            // 
            this._url.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this._url.Location = new System.Drawing.Point(12, 47);
            this._url.Name = "_url";
            this._url.Size = new System.Drawing.Size(1003, 19);
            this._url.TabIndex = 8;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1109, 474);
            this.Controls.Add(this._url);
            this.Controls.Add(this._buttonDelete);
            this.Controls.Add(this._buttonGen);
            this.Controls.Add(this._buttonLoad);
            this.Controls.Add(this._buttonSave);
            this.Controls.Add(this._classDefine);
            this.Controls.Add(this._listBox);
            this.Controls.Add(this._buttonAdd);
            this.Controls.Add(this._input);
            this.Name = "MainForm";
            this.Text = "SystemTable";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox _input;
        private System.Windows.Forms.Button _buttonAdd;
        private System.Windows.Forms.ListBox _listBox;
        private System.Windows.Forms.TextBox _classDefine;
        private System.Windows.Forms.Button _buttonSave;
        private System.Windows.Forms.Button _buttonLoad;
        private System.Windows.Forms.Button _buttonGen;
        private System.Windows.Forms.Button _buttonDelete;
        private System.Windows.Forms.TextBox _url;
    }
}

