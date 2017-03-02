using System.Data;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using LambdicSql;
using LambdicSql.SqlServer;
using LambdicSql.feat.Dapper;
using static LambdicSql.SqlServer.Symbol;
using Test.Helper;

namespace Test
{
    [TestClass]
    public class Initializer
    {
        [AssemblyInitialize()]
        public static void AssemblyInitialize(TestContext context)
        {
            using (var conn = TestEnvironment.CreateConnection(context))
            {
                conn.Open();
                DropTables(conn);
                conn.Execute(CreateStaff);
                conn.Execute(CreateRemuneration);
                conn.Execute(CreateData);
                InsertData(conn);
            }
        }

        static void DropTables(IDbConnection conn)
        {
            try
            {
                conn.Execute(Db<DB>.Sql(db => DropTable(db.tbl_staff)));
            }
            catch { }

            try
            {
                conn.Execute(Db<DB>.Sql(db => DropTable(db.tbl_remuneration)));
            }
            catch { }

            try
            {
                conn.Execute(Db<DB>.Sql(db => DropTable(db.tbl_data)));
            }
            catch { }
        }

        static Sql CreateStaff = Db<DB>.Sql(db =>
            CreateTable(
                 db.tbl_staff,
                 new Column(db.tbl_staff.id, DataType.Int(), NotNull(), PrimaryKey()),
                 new Column(db.tbl_staff.name, DataType.VarChar(50), NotNull())
                 ));

        static Sql CreateRemuneration = Db<DB>.Sql(db =>
            CreateTable(
                 db.tbl_remuneration,
                 new Column(db.tbl_remuneration.id, DataType.Int(), NotNull(), PrimaryKey()),
                 new Column(db.tbl_remuneration.staff_id, DataType.Int(), NotNull()),
                 new Column(db.tbl_remuneration.payment_date, DataType.VarChar(50), NotNull()),
                 new Column(db.tbl_remuneration.money, DataType.Decimal(), NotNull())
                 ));

        static Sql CreateData = Db<DB>.Sql(db =>
                 CreateTable(db.tbl_data,
                     new Column(db.tbl_data.id, DataType.Int()),
                     new Column(db.tbl_data.val1, DataType.Int()),
                     new Column(db.tbl_data.val2, DataType.Char(10))
                 ));

        static void InsertData(IDbConnection conn)
        {
            foreach (var data in new object[][]
                        {
                                new object[] {1, "Emma"},
                                new object[] {2, "Noah"},
                                new object[] {3, "Olivia"},
                                new object[] {4, "Jackson" }
                        })
            {
                var sql = Db<DB>.Sql(db =>
                     InsertInto(db.tbl_staff, db.tbl_staff.id, db.tbl_staff.name).
                     Values(data[0], data[1])
                    );
                conn.Execute(sql);
            }

            foreach (var data in new object[][]
                        {
                                new object[] {1, 1, "2016/1/1", (decimal)3000.0000},
                                new object[] {2, 1, "2016/2/1", (decimal)3000.0000 },
                                new object[] {3, 2, "2016/1/1", (decimal)2000.0000 },
                                new object[] {4, 2, "2016/2/1", (decimal)2500.0000 },
                                new object[] {5, 3, "2016/1/1", (decimal)4000.0000 },
                                new object[] {6, 3, "2016/2/1", (decimal)4000.0000 },
                                new object[] {7, 4, "2016/1/1", (decimal)3500.0000 },
                                new object[] {8, 5, "2016/2/1", (decimal)3500.0000 }
                        })
            {
                var sql = Db<DB>.Sql(db =>
                       InsertInto(db.tbl_remuneration,
                           db.tbl_remuneration.id,
                           db.tbl_remuneration.staff_id,
                           db.tbl_remuneration.payment_date,
                           db.tbl_remuneration.money).
                       Values(data[0], data[1], data[2], data[3])
                        );
                conn.Execute(sql);
            }
        }
    }
}
