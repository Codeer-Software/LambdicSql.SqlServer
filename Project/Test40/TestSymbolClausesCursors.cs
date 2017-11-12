using System.Data;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using LambdicSql;
using LambdicSql.feat.Dapper;
using static LambdicSql.SqlServer.Symbol;
using Test.Helper;
using LambdicSql.SqlServer;
using LambdicSql.ConverterServices.SymbolConverters;

namespace Test
{
    [TestClass]
    public class TestSymbolClausesCursors
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
        public void Test()
        {
            int id = 0;
            string name = string.Empty;
            string staffCursor = nameof(staffCursor);
            
            var sql = Db<DB>.Sql(db =>
                DeclareCursorFor(staffCursor).Select(new { db.tbl_staff.id, db.tbl_staff.name }).From(db.tbl_staff).
                Open(staffCursor).
                FetchNextFromInto(staffCursor, id, name).
                While(AtAtFetch_Status() == 0).
                Begin().
                Select(new { id, name }).FetchNextFromInto(staffCursor, id, name).
                End().
                Close(staffCursor).
                Deallocate(staffCursor)
            );

            sql.Gen(_connection);

            var datas = _connection.Query(sql).ToList();
        }


        [MethodFormatConverter("([0].データ所持_組織Id = [1] or exists (select * from 閲覧許可組織 where 閲覧許可組織.組織Id = [0].データ所持_組織Id and 閲覧許可組織.許可済組織Id = [1])")]
        static bool y(object table, long id) => false;

        static int 組織Id = 100;
        static Sql x  => Db<DB>.Sql(db => y(db.tbl_staff, 組織Id));
    }
}
