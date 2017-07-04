using LambdicSql.ConverterServices;
using LambdicSql.ConverterServices.SymbolConverters;

namespace LambdicSql.SqlServer
{
    public static partial class Symbol
    {
        /// <summary>
        /// DATALENGTH function.
        /// https://docs.microsoft.com/ja-jp/sql/t-sql/functions/datalength-transact-sql
        /// </summary>
        /// <param name="expression">Is an expression of any data type.</param>
        /// <returns>bigint if expression is of the varchar(max), nvarchar(max) or varbinary(max) data types; otherwise int.</returns>
        [FuncStyleConverter]
        public static long Datalength(object expression) { throw new InvalitContextException(nameof(Datalength)); }


        //TODO:SQL numeric 38 decimal 29
        /// <summary>
        /// IDENT_CURRENT function.
        /// https://docs.microsoft.com/ja-jp/sql/t-sql/functions/ident-current-transact-sql
        /// </summary>
        /// <param name="table_name">Is the name of the table whose identity value is returned. table_name is varchar, with no default.</param>
        /// <returns>numeric(38,0)</returns>
        [MethodFormatConverter(Format = "IDENT_CURRENT([$0])")]
        public static decimal? Ident_Current(string table_name) { throw new InvalitContextException(nameof(Ident_Current)); }

        /// <summary>
        /// IDENT_INCR function.
        /// https://docs.microsoft.com/ja-jp/sql/t-sql/functions/ident-incr-transact-sql
        /// </summary>
        /// <param name="table_name">Is an expression specifying the table or view to check for a valid identity increment value.</param>
        /// <returns>numeric</returns>
        [MethodFormatConverter(Format = "IDENT_INCR([$0])")]
        public static decimal? Ident_Incr(string table_name) { throw new InvalitContextException(nameof(Ident_Incr)); }

        /// <summary>
        /// IDENT_SEED function.
        /// https://docs.microsoft.com/ja-jp/sql/t-sql/functions/ident-seed-transact-sql
        /// </summary>
        /// <param name="table_name">Is an expression that specifies the table or view to check for a identity seed value.</param>
        /// <returns></returns>
        [MethodFormatConverter(Format = "IDENT_SEED([$0])")]
        public static decimal? Ident_Seed(string table_name) { throw new InvalitContextException(nameof(Ident_Seed)); }

        /// <summary>
        /// IDENTITY function.
        /// https://docs.microsoft.com/ja-jp/sql/t-sql/functions/identity-function-transact-sql
        /// </summary>
        /// <param name="dataType">Is the data type of the identity column. Valid data types for an identity column are any data types of the integer data type category, except for the bit data type, or decimal data type.</param>
        /// <param name="columnName">Is the name of the column that is to be inserted into the new table.</param>
        /// <param name="seed">Is the integer value to be assigned to the first row in the table. Each subsequent row is assigned the next identity value, which is equal to the last IDENTITY value plus the increment value. If neither seed nor increment is specified, both default to 1.</param>
        /// <param name="increment">Is the integer value to add to the seed value for successive rows in the table.</param>
        /// <returns>Returns the same as data_type.</returns>
        [MethodFormatConverter(Format = "IDENTITY([0, 1, 2]) AS [3]")]
        public static DataTypeElement Identity(DataTypeElement dataType, string columnName, int seed, int increment) { throw new InvalitContextException(nameof(Identity)); }
        [MethodFormatConverter(Format = "IDENTITY([0, 1]) AS [2]")]
        public static DataTypeElement Identity(DataTypeElement dataType, string columnName, int seed) { throw new InvalitContextException(nameof(Identity)); }
        [MethodFormatConverter(Format = "IDENTITY([0]) AS [$1]")]
        public static DataTypeElement Identity(DataTypeElement dataType, string columnName) { throw new InvalitContextException(nameof(Identity)); }

        /// <summary>
        /// SQL_VARIANT_PROPERTY function.
        /// https://docs.microsoft.com/ja-jp/sql/t-sql/functions/sql-variant-property-transact-sql
        /// </summary>
        /// <param name="expression">Is an expression of type sql_variant.</param>
        /// <param name="property">Contains the name of the sql_variant property for which information is to be provided. property is varchar(128), and can be any one of the following values.</param>
        /// <returns>sql_variant</returns>
        [MethodFormatConverter(Format = "SQL_VARIANT_PROPERTY([0], [$1])")]
        public static object Sql_Variant_Property(object expression, string property) { throw new InvalitContextException(nameof(Sql_Variant_Property)); }

    }
}
