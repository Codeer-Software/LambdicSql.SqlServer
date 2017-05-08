using System.Data;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using LambdicSql;
using LambdicSql.feat.Dapper;
using static LambdicSql.SqlServer.Symbol;
using Test.Helper;
using LambdicSql.SqlServer;

namespace Test
{
    [TestClass]
    public class TestSymbolFuncsString
    {
        public TestContext TestContext { get; set; }
        public IDbConnection _connection;

        [TestInitialize]
        public void TestInitialize()
        {
            _connection = TestEnvironment.CreateConnection(TestContext);
            _connection.Open();
        }

        [TestCleanup]
        public void TestCleanup() => _connection.Dispose();
        
        [TestMethod]
        [TestCategory("String")]
        [Priority(1)]
        public void Test_Concat()
        {
            var sql = Db<DB>.Sql(db =>
               Select(new
               {
                   Val = Concat(db.tbl_staff.name, "a", "b")
               }).
               From(db.tbl_staff));

            var datas = _connection.Query(sql).ToList();
            Assert.IsTrue(0 < datas.Count);
            AssertEx.AreEqual(sql, _connection,
@"SELECT
	CONCAT(tbl_staff.name, @p_0, @p_1) AS Val
FROM tbl_staff", "a", "b");
        }

        // CONCAT_WS supports only SQL Server 2017.
        // Ths test does not execute query.
        [TestMethod]
        [TestCategory("String")]
        [Priority(1)]
        public void Test_Concat_WS()
        {
            var sql = Db<DB>.Sql(db =>
               Select(new
               {
                   Val = Concat_WS(db.tbl_staff.name, "a", "b")
               }).
               From(db.tbl_staff));

            
            AssertEx.AreEqual(sql, _connection,
@"SELECT
	CONCAT_WS(tbl_staff.name, @p_0, @p_1) AS Val
FROM tbl_staff", "a", "b");
        }

        [TestMethod]
        [TestCategory("String")]
        [Priority(1)]
        public void Test_Len()
        {
            var sql = Db<DB>.Sql(db =>
               Select(new
               {
                   Val = Len(db.tbl_staff.name)
               }).
               From(db.tbl_staff));

            var datas = _connection.Query(sql).ToList();
            Assert.IsTrue(0 < datas.Count);
            AssertEx.AreEqual(sql, _connection,
 @"SELECT
	LEN(tbl_staff.name) AS Val
FROM tbl_staff");
        }

        [TestMethod]
        [TestCategory("String")]
        [Priority(1)]
        public void Test_Lower()
        {
            var sql = Db<DB>.Sql(db =>
               Select(new
               {
                   Val = Lower(db.tbl_staff.name)
               }).
               From(db.tbl_staff));

            var datas = _connection.Query(sql).ToList();
            Assert.IsTrue(0 < datas.Count);
            AssertEx.AreEqual(sql, _connection,
@"SELECT
	LOWER(tbl_staff.name) AS Val
FROM tbl_staff");
        }

        [TestMethod]
        [TestCategory("String")]
        [Priority(1)]
        public void Test_Upper()
        {
            var sql = Db<DB>.Sql(db =>
               Select(new
               {
                   Val = Upper(db.tbl_staff.name)
               }).
               From(db.tbl_staff));

            var datas = _connection.Query(sql).ToList();
            Assert.IsTrue(0 < datas.Count);
            AssertEx.AreEqual(sql, _connection,
@"SELECT
	UPPER(tbl_staff.name) AS Val
FROM tbl_staff");
        }

        [TestMethod]
        [TestCategory("String")]
        [Priority(1)]
        public void Test_Replace()
        {
            var sql = Db<DB>.Sql(db =>
               Select(new
               {
                   Val = Replace(db.tbl_staff.name, "a", "b")
               }).
               From(db.tbl_staff));

            var datas = _connection.Query(sql).ToList();
            Assert.IsTrue(0 < datas.Count);
            AssertEx.AreEqual(sql, _connection,
@"SELECT
	REPLACE(tbl_staff.name, @p_0, @p_1) AS Val
FROM tbl_staff",
"a", "b");
        }

        [TestMethod]
        [TestCategory("String")]
        [Priority(1)]
        public void Test_Substring()
        {
            var sql = Db<DB>.Sql(db =>
               Select(new
               {
                   Val = Substring(db.tbl_staff.name, 0, 1)
               }).
               From(db.tbl_staff));

            var datas = _connection.Query(sql).ToList();
            Assert.IsTrue(0 < datas.Count);
            AssertEx.AreEqual(sql, _connection,
@"SELECT
	SUBSTRING(tbl_staff.name, @p_0, @p_1) AS Val
FROM tbl_staff",
0, 1);
        }

        [TestMethod]
        [TestCategory("String")]
        [Priority(1)]
        public void Test_Space()
        {
            var sql = Db<DB>.Sql(db =>
            Select(new
            {
                Val = Space(5)
            }).From(db.tbl_staff));
            var data = _connection.Query(sql).ToList();
            Assert.IsTrue(data.Count > 0);
            AssertEx.AreEqual(sql, _connection,
@"SELECT
	SPACE(@p_0) AS Val
FROM tbl_staff",
            5);
        }

        [TestMethod]
        [TestCategory("String")]
        [Priority(1)]
        public void Test_Str()
        {
            var sql = Db<DB>.Sql(db =>
            Select(new
            {
                Val = Str(123.45, 6, 1)
            }).From(db.tbl_staff));
            var data = _connection.Query(sql).ToList();
            Assert.IsTrue(data.Count > 0);
            AssertEx.AreEqual(sql, _connection,
@"SELECT
	STR(@p_0, @p_1, @p_2) AS Val
FROM tbl_staff",
            123.45, 6, 1);
        }

        [TestMethod]
        [TestCategory("String")]
        [Priority(1)]
        public void Test_Ascii()
        {
            var sql = Db<DB>.Sql(db =>
            Select(new
            {
                Val = Ascii('A')
            }).From(db.tbl_staff));
            var data = _connection.Query(sql).ToList();
            Assert.IsTrue(data.Count > 0);
            AssertEx.AreEqual(sql, _connection,
@"SELECT
	ASCII(@p_0) AS Val
FROM tbl_staff",
            'A');
        }

        [TestMethod]
        [TestCategory("String")]
        [Priority(1)]
        public void Test_Char()
        {
            var sql = Db<DB>.Sql(db =>
            Select(new
            {
                Val = Symbol.Char(65)
            }).From(db.tbl_staff));
            var data = _connection.Query(sql).ToList();
            Assert.IsTrue(data.Count > 0);
            AssertEx.AreEqual(sql, _connection,
@"SELECT
	CHAR(@p_0) AS Val
FROM tbl_staff",
            65);
        }

        [TestMethod]
        [TestCategory("String")]
        [Priority(1)]
        public void Test_CharIndex()
        {
            var sql = Db<DB>.Sql(db =>
            Select(new
            {
                Val = CharIndex(db.tbl_staff.name, "c", 0)
            }).From(db.tbl_staff));
            var data = _connection.Query(sql).ToList();
            Assert.IsTrue(data.Count > 0);
            AssertEx.AreEqual(sql, _connection,
@"SELECT
	CHARINDEX(tbl_staff.name, @p_0, @p_1) AS Val
FROM tbl_staff",
            "c", 0);
        }

        [TestMethod]
        [TestCategory("String")]
        [Priority(1)]
        public void Test_CharIndex_2()
        {
            var sql = Db<DB>.Sql(db =>
            Select(new
            {
                Val = CharIndex(db.tbl_staff.name, "c")
            }).From(db.tbl_staff));
            var data = _connection.Query(sql).ToList();
            Assert.IsTrue(data.Count > 0);
            AssertEx.AreEqual(sql, _connection,
@"SELECT
	CHARINDEX(tbl_staff.name, @p_0) AS Val
FROM tbl_staff",
            "c");
        }

        [TestMethod]
        [TestCategory("String")]
        [Priority(1)]
        public void Test_Difference()
        {
            var sql = Db<DB>.Sql(db =>
            Select(new
            {
                Val = Difference(db.tbl_staff.name, "Emma")
            }).From(db.tbl_staff));
            var data = _connection.Query(sql).ToList();
            Assert.IsTrue(data.Count > 0);
            AssertEx.AreEqual(sql, _connection,
@"SELECT
	DIFFERENCE(tbl_staff.name, @p_0) AS Val
FROM tbl_staff",
            "Emma");
        }

        [TestMethod]
        [TestCategory("String")]
        [Priority(1)]
        public void Test_Format()
        {
            var sql = Db<DB>.Sql(db =>
            Select(new
            {
                Val = Symbol.Format(1000, "N", "ja-jp")
            }).From(db.tbl_staff));
            var data = _connection.Query(sql).ToList();
            Assert.IsTrue(data.Count > 0);
            AssertEx.AreEqual(sql, _connection,
@"SELECT
	FORMAT(@p_0, @p_1, @p_2) AS Val
FROM tbl_staff",
            1000, "N", "ja-jp");
        }

        [TestMethod]
        [TestCategory("String")]
        [Priority(1)]
        public void Test_Left()
        {
            var sql = Db<DB>.Sql(db =>
            Select(new
            {
                Val = Left(db.tbl_staff.name, 2)
            }).From(db.tbl_staff));
            var data = _connection.Query(sql).ToList();
            Assert.IsTrue(data.Count > 0);
            AssertEx.AreEqual(sql, _connection,
@"SELECT
	LEFT(tbl_staff.name, @p_0) AS Val
FROM tbl_staff"
            , 2);
        }

        [TestMethod]
        [TestCategory("String")]
        [Priority(1)]
        public void Test_Ltrim()
        {
            var sql = Db<DB>.Sql(db =>
            Select(new
            {
                Val = Ltrim(db.tbl_staff.name)
            }).From(db.tbl_staff));
            var data = _connection.Query(sql).ToList();
            Assert.IsTrue(data.Count > 0);
            AssertEx.AreEqual(sql, _connection,
@"SELECT
	LTRIM(tbl_staff.name) AS Val
FROM tbl_staff");
        }

        [TestMethod]
        [TestCategory("String")]
        [Priority(1)]
        public void Test_NChar()
        {
            var sql = Db<DB>.Sql(db =>
            Select(new
            {
                Val = NChar(0xDD7F)
            }));
            var data = _connection.Query(sql).ToList();
            Assert.IsTrue(data.Count > 0);
            AssertEx.AreEqual(sql, _connection,
@"SELECT
	NCHAR(@p_0) AS Val",
         0xDD7F);
        }

        [TestMethod]
        [TestCategory("String")]
        [Priority(1)]
        public void Test_PatIndex()
        {
            var sql = Db<DB>.Sql(db =>
            Select(new
            {
                Val = PatIndex("%mm%", db.tbl_staff.name)
            }).From(db.tbl_staff));
            var data = _connection.Query(sql).ToList();
            Assert.IsTrue(data.Count > 0);
            AssertEx.AreEqual(sql, _connection,
@"SELECT
	PATINDEX(@p_0, tbl_staff.name) AS Val
FROM tbl_staff",
            "%mm%");
        }

        [TestMethod]
        [Priority(1)]
        [TestCategory("String")]
        public void Test_QuoteName()
        {
            var sql = Db<DB>.Sql(db =>
            Select(new
            {
                Val = QuoteName("abc[]def")
            }));
            var data = _connection.Query(sql).ToList();
            Assert.IsTrue(data.Count > 0);
            AssertEx.AreEqual(sql, _connection,
@"SELECT
	QUOTENAME(@p_0) AS Val",
            "abc[]def");
        }

        [TestMethod]
        [TestCategory("String")]
        [Priority(1)]
        public void Test_Replicate()
        {
            var sql = Db<DB>.Sql(db =>
            Select(new
            {
                Val = Replicate("0", 5)
            }));
            var data = _connection.Query(sql).ToList();
            Assert.IsTrue(data.Count > 0);
            AssertEx.AreEqual(sql, _connection,
@"SELECT
	REPLICATE(@p_0, @p_1) AS Val",
            "0", 5);
        }

        [TestMethod]
        [TestCategory("String")]
        [Priority(1)]
        public void Test_Reverse()
        {
            var sql = Db<DB>.Sql(db =>
            Select(new
            {
                Val = Reverse("abcdefghijklmnopqrstuvwxyz")
            }));
            var data = _connection.Query(sql).ToList();
            Assert.IsTrue(data.Count > 0);
            AssertEx.AreEqual(sql, _connection,
@"SELECT
	REVERSE(@p_0) AS Val",
            "abcdefghijklmnopqrstuvwxyz");
        }

        [TestMethod]
        [TestCategory("String")]
        [Priority(1)]
        public void Test_Right()
        {
            var sql = Db<DB>.Sql(db =>
            Select(new
            {
                Val = Right(db.tbl_staff.name, 2)
            }).From(db.tbl_staff));
            var data = _connection.Query(sql).ToList();
            Assert.IsTrue(data.Count > 0);
            AssertEx.AreEqual(sql, _connection,
@"SELECT
	RIGHT(tbl_staff.name, @p_0) AS Val
FROM tbl_staff"
            , 2);
        }

        [TestMethod]
        [Priority(1)]
        [TestCategory("String")]
        public void Test_Rtrim()
        {
            var sql = Db<DB>.Sql(db =>
            Select(new
            {
                Val = Rtrim(db.tbl_staff.name)
            }).From(db.tbl_staff));
            var data = _connection.Query(sql).ToList();
            Assert.IsTrue(data.Count > 0);
            AssertEx.AreEqual(sql, _connection,
@"SELECT
	RTRIM(tbl_staff.name) AS Val
FROM tbl_staff");
        }

        [TestMethod]
        [TestCategory("String")]
        [Priority(1)]
        public void Test_SoundEx()
        {
            var sql = Db<DB>.Sql(db =>
            Select(new
            {
                Val = SoundEx(db.tbl_staff.name)
            }).From(db.tbl_staff));
            var data = _connection.Query(sql).ToList();
            Assert.IsTrue(data.Count > 0);
            AssertEx.AreEqual(sql, _connection,
@"SELECT
	SOUNDEX(tbl_staff.name) AS Val
FROM tbl_staff");
        }

        /// <summary>
        /// String_Agg starts with SQL Server 2017
        /// now test only sql string.
        /// </summary>
        [TestMethod]
        [TestCategory("String")]
        [Priority(1)]
        public void Test_String_Agg_Char()
        {
            var sql = Db<DB>.Sql(db =>
            Select(new
            {
                Val = String_Agg(db.tbl_staff.name, Char(13))
            }).From(db.tbl_staff));
            AssertEx.AreEqual(sql, _connection,
@"SELECT
	STRING_AGG(tbl_staff.name, CHAR(@p_0)) AS Val
FROM tbl_staff",
           13);
        }

        /// <summary>
        /// String_Agg starts with SQL Server 2017
        /// now test only sql string.
        /// </summary>
        [TestMethod]
        [TestCategory("String")]
        [Priority(1)]
        public void Test_String_Agg_String()
        {
            var sql = Db<DB>.Sql(db =>
            Select(new
            {
                Val = String_Agg(db.tbl_staff.name, ",")
            }).From(db.tbl_staff));
            AssertEx.AreEqual(sql, _connection,
@"SELECT
	STRING_AGG(tbl_staff.name, @p_0) AS Val
FROM tbl_staff",
            ",");
        }

        /// <summary>
        /// String_Escape starts with SQL Server 2016
        /// now test only sql string.
        /// </summary>
        [TestMethod]
        [TestCategory("String")]
        [Priority(1)]
        public void Test_String_Escape()
        {
            var sql = Db<DB>.Sql(db =>
            Select(new
            {
                Val = String_Escape("\\   /     \"  \'  ", "JSON")
            }));
            AssertEx.AreEqual(sql, _connection,
@"SELECT
	STRING_ESCAPE(@p_0, @p_1) AS Val",
            "\\   /     \"  \'  ", "JSON");
        }

        /// <summary>
        /// String_Agg starts with SQL Server 2016 and compatiblity Level require 130
        /// now test only sql string.
        /// </summary>
        [TestMethod]
        [TestCategory("String")]
        [Priority(1)]
        public void Test_String_Split_Char()
        {
            var sql = Db<DB>.Sql(db =>
            Select(new
            {
                Val = String_Split(db.tbl_staff.name, Char(13))
            }).From(db.tbl_staff));
            AssertEx.AreEqual(sql, _connection,
@"SELECT
	STRING_SPLIT(tbl_staff.name, CHAR(@p_0)) AS Val
FROM tbl_staff", 13);
        }

        /// <summary>
        /// String_Agg starts with SQL Server 2016 and compatiblity Level require 130
        /// now test only sql string.
        /// </summary>
        [TestMethod]
        [TestCategory("String")]
        [Priority(1)]
        public void Test_String_Split_String()
        {
            var sql = Db<DB>.Sql(db =>
            Select(new
            {
                Val = String_Split(db.tbl_staff.name, ",")
            }).From(db.tbl_staff));
            AssertEx.AreEqual(sql, _connection,
@"SELECT
	STRING_SPLIT(tbl_staff.name, @p_0) AS Val
FROM tbl_staff",
            ",");
        }

        [TestMethod]
        [TestCategory("String")]
        [Priority(1)]
        public void Test_Stuff()
        {
            var sql = Db<DB>.Sql(db =>
            Select(new
            {
                Val = Stuff(db.tbl_staff.name, 1L, 2L, "ddddd")
            }).From(db.tbl_staff));
            var data = _connection.Query(sql).ToList();
            Assert.IsTrue(data.Count > 0);
            AssertEx.AreEqual(sql, _connection,
@"SELECT
	STUFF(tbl_staff.name, @p_0, @p_1, @p_2) AS Val
FROM tbl_staff",
            1L, 2L, "ddddd");
        }

        //TRANSLATE is support with SQL Server 2017
        [TestMethod]
        [TestCategory("String")]
        [Priority(1)]
        public void Test_Translate()
        {
            var sql = Db<DB>.Sql(db =>
            Select(new
            {
                Val = Translate("'2*[3+4]/{7-2}'", "[]{}", "()()")
            }));
            AssertEx.AreEqual(sql, _connection,
@"SELECT
	TRANSLATE(@p_0, @p_1, @p_2) AS Val",
            "'2*[3+4]/{7-2}'", "[]{}", "()()");
        }

        [TestMethod]
        [TestCategory("String")]
        [Priority(1)]
        public void Test_Trim()
        {
            var sql = Db<DB>.Sql(db =>
            Select(new
            {
                Val = Trim("        Trim         ")
            }));
            AssertEx.AreEqual(sql, _connection,
@"SELECT
	TRIM(@p_0) AS Val", "        Trim         ");
        }

        [TestMethod]
        [TestCategory("String")]
        [Priority(1)]
        public void Test_Unicode()
        {
            var sql = Db<DB>.Sql(db =>
            Select(new
            {
                Val = Unicode(new DbParam<string>{ Value = "𠮟", DbType = DbType.String })
            }));
            var data = _connection.Query(sql).ToList();
            Assert.IsTrue(data.Count > 0);
            AssertEx.AreEqual(sql, _connection,
@"SELECT
	UNICODE(@p_0) AS Val",
            new DbParams
            {
                { "@p_0", new DbParam { Value = "𠮟", DbType = DbType.String } }
            });
        }
    }
}