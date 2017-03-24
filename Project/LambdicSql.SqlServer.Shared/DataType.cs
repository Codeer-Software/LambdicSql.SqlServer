using LambdicSql.ConverterServices;
using LambdicSql.ConverterServices.SymbolConverters;

namespace LambdicSql.SqlServer
{
    //https://msdn.microsoft.com/en-us/library/ms187752.aspx

    /// <summary>
    /// Data type.
    /// It can only be used within methods of the LambdicSql.Db class.
    /// </summary>
    public static class DataType
    {
        /// <summary>
        /// BINARY
        /// </summary>
        /// <returns>BINARY</returns>
        [ClauseStyleConverter]
        public static DataTypeElement Binary() { throw new InvalitContextException(nameof(Binary)); }

        /// <summary>
        /// BINARY
        /// </summary>
        /// <param name="n">n</param>
        /// <returns>BINARY</returns>
        [FuncStyleConverter]
        public static DataTypeElement Binary(int n) { throw new InvalitContextException(nameof(Binary)); }

        /// <summary>
        /// BIT
        /// </summary>
        /// <returns>BIT</returns>
        [ClauseStyleConverter]
        public static DataTypeElement Bit() { throw new InvalitContextException(nameof(Bit)); }

        /// <summary>
        /// BIT
        /// </summary>
        /// <param name="n">n</param>
        /// <returns>BIT</returns>
        [FuncStyleConverter]
        public static DataTypeElement Bit(int n) { throw new InvalitContextException(nameof(Bit)); }

        /// <summary>
        /// CHAR
        /// </summary>
        /// <returns>CHAR</returns>
        [ClauseStyleConverter]
        public static DataTypeElement Char() { throw new InvalitContextException(nameof(Char)); }

        /// <summary>
        /// CHAR
        /// </summary>
        /// <param name="n">n</param>
        /// <returns>CHAR</returns>
        [FuncStyleConverter]
        public static DataTypeElement Char(int n) { throw new InvalitContextException(nameof(Char)); }
        
        /// <summary>
        /// DATE
        /// </summary>
        /// <returns>DATE</returns>
        [ClauseStyleConverter]
        public static DataTypeElement Date() { throw new InvalitContextException(nameof(Date)); }

        /// <summary>
        /// DATETIME
        /// </summary>
        /// <returns>DATETIME</returns>
        [ClauseStyleConverter]
        public static DataTypeElement DateTime() { throw new InvalitContextException(nameof(DateTime)); }

        /// <summary>
        /// DATETIME2
        /// </summary>
        /// <returns>DATETIME2</returns>
        [ClauseStyleConverter]
        public static DataTypeElement DateTime2() { throw new InvalitContextException(nameof(DateTime2)); }

        /// <summary>
        /// DATETIME2
        /// </summary>
        /// <param name="n">n</param>
        /// <returns>DATETIME2</returns>
        [FuncStyleConverter]
        public static DataTypeElement DateTime2(int n) { throw new InvalitContextException(nameof(DateTime2)); }

        /// <summary>
        /// DATETIMEOFFSET
        /// </summary>
        /// <returns>DATETIMEOFFSET</returns>
        [ClauseStyleConverter]
        public static DataTypeElement DateTimeOffset() { throw new InvalitContextException(nameof(DateTimeOffset)); }

        /// <summary>
        /// DATETIMEOFFSET
        /// </summary>
        /// <param name="n">n</param>
        /// <returns>DATETIMEOFFSET</returns>
        [FuncStyleConverter]
        public static DataTypeElement DateTimeOffset(int n) { throw new InvalitContextException(nameof(DateTimeOffset)); }

        /// <summary>
        /// DECIMAL
        /// </summary>
        /// <returns>DECIMAL</returns>
        [ClauseStyleConverter]
        public static DataTypeElement Decimal() { throw new InvalitContextException(nameof(Decimal)); }

        /// <summary>
        /// DECIMAL
        /// </summary>
        /// <param name="precision">precision</param>
        /// <returns>DECIMAL</returns>
        [ClauseStyleConverter]
        public static DataTypeElement Decimal(int precision) { throw new InvalitContextException(nameof(Decimal)); }


        /// <summary>
        /// DECIMAL
        /// </summary>
        /// <param name="precision">precision</param>
        /// <param name="scale">scale</param>
        /// <returns>DECIMAL</returns>
        [ClauseStyleConverter]
        public static DataTypeElement Decimal(int precision, int scale) { throw new InvalitContextException(nameof(Decimal)); }

        /// <summary>
        /// FLOAT
        /// </summary>
        /// <returns>FLOAT</returns>
        [ClauseStyleConverter]
        public static DataTypeElement Float() { throw new InvalitContextException(nameof(Float)); }

        /// <summary>
        /// FLOAT
        /// </summary>
        /// <param name="n">n</param>
        /// <returns>FLOAT</returns>
        [FuncStyleConverter]
        public static DataTypeElement Float(int n) { throw new InvalitContextException(nameof(Float)); }

        /// <summary>
        /// IMAGE
        /// </summary>
        /// <returns>IMAGE</returns>
        [ClauseStyleConverter]
        public static DataTypeElement Image() { throw new InvalitContextException(nameof(Image)); }

        /// <summary>
        /// INT
        /// </summary>
        /// <returns>INT</returns>
        [ClauseStyleConverter]
        public static DataTypeElement Int() { throw new InvalitContextException(nameof(Int)); }
        
        /// <summary>
        /// MONEY
        /// </summary>
        /// <returns>MONEY</returns>
        [ClauseStyleConverter]
        public static DataTypeElement Money() { throw new InvalitContextException(nameof(Money)); }

        /// <summary>
        /// NCHAR
        /// </summary>
        /// <returns>NCHAR</returns>
        [ClauseStyleConverter]
        public static DataTypeElement NChar() { throw new InvalitContextException(nameof(NChar)); }

        /// <summary>
        /// NCHAR
        /// </summary>
        /// <param name="n">n</param>
        /// <returns>NCHAR</returns>
        [FuncStyleConverter]
        public static DataTypeElement NChar(int n) { throw new InvalitContextException(nameof(NChar)); }

        /// <summary>
        /// NTEXT
        /// </summary>
        /// <returns>NTEXT</returns>
        [ClauseStyleConverter]
        public static DataTypeElement NText() { throw new InvalitContextException(nameof(NText)); }

        /// <summary>
        /// NUMERIC
        /// </summary>
        /// <returns>NUMERIC</returns>
        [ClauseStyleConverter]
        public static DataTypeElement Numeric() { throw new InvalitContextException(nameof(Numeric)); }

        /// <summary>
        /// NUMERIC
        /// </summary>
        /// <param name="precision">precision</param>
        /// <returns>NUMERIC</returns>
        [FuncStyleConverter]
        public static DataTypeElement Numeric(int precision) { throw new InvalitContextException(nameof(Numeric)); }

        /// <summary>
        /// NUMERIC
        /// </summary>
        /// <param name="precision">precision</param>
        /// <param name="scale">scale</param>
        /// <returns>NUMERIC</returns>
        [FuncStyleConverter]
        public static DataTypeElement Numeric(int precision, int scale) { throw new InvalitContextException(nameof(Numeric)); }

        /// <summary>
        /// NVARCHAR
        /// </summary>
        /// <returns>NVARCHAR</returns>
        [ClauseStyleConverter]
        public static DataTypeElement NVarChar() { throw new InvalitContextException(nameof(NVarChar)); }

        /// <summary>
        /// NVARCHAR
        /// </summary>
        /// <param name="n">n</param>
        /// <returns>NVARCHAR</returns>
        [FuncStyleConverter]
        public static DataTypeElement NVarChar(int n) { throw new InvalitContextException(nameof(NVarChar)); }

        /// <summary>
        /// REAL
        /// </summary>
        /// <returns>REAL</returns>
        [ClauseStyleConverter]
        public static DataTypeElement Real() { throw new InvalitContextException(nameof(Real)); }

        /// <summary>
        /// SMALLDATETIME
        /// </summary>
        /// <returns>SMALLDATETIME</returns>
        [ClauseStyleConverter]
        public static DataTypeElement SmallDateTime() { throw new InvalitContextException(nameof(SmallDateTime)); }

        /// <summary>
        /// SMALLINT
        /// </summary>
        /// <returns>SMALLINT</returns>
        [ClauseStyleConverter]
        public static DataTypeElement SmallInt() { throw new InvalitContextException(nameof(SmallInt)); }

        /// <summary>
        /// SMALLMONEY
        /// </summary>
        /// <returns>SMALLMONEY</returns>
        [ClauseStyleConverter]
        public static DataTypeElement SmallMoney() { throw new InvalitContextException(nameof(SmallMoney)); }

        /// <summary>
        /// TEXT
        /// </summary>
        /// <returns>TEXT</returns>
        [ClauseStyleConverter]
        public static DataTypeElement Text() { throw new InvalitContextException(nameof(Text)); }

        /// <summary>
        /// TIME
        /// </summary>
        /// <returns>TIME</returns>
        [ClauseStyleConverter]
        public static DataTypeElement Time() { throw new InvalitContextException(nameof(Time)); }

        /// <summary>
        /// TIME
        /// </summary>
        /// <param name="n">n</param>
        /// <returns>TIME</returns>
        [FuncStyleConverter]
        public static DataTypeElement Time(int n) { throw new InvalitContextException(nameof(Time)); }

        /// <summary>
        /// TINYINT
        /// </summary>
        /// <returns>TINYINT</returns>
        [ClauseStyleConverter]
        public static DataTypeElement TinyInt() { throw new InvalitContextException(nameof(TinyInt)); }

        /// <summary>
        /// VARBINARY
        /// </summary>
        /// <returns>VARBINARY</returns>
        [ClauseStyleConverter]
        public static DataTypeElement VarBinary() { throw new InvalitContextException(nameof(VarBinary)); }

        /// <summary>
        /// VARBINARY
        /// </summary>
        /// <param name="n">n</param>
        /// <returns>VARBINARY</returns>
        [FuncStyleConverter]
        public static DataTypeElement VarBinary(int n) { throw new InvalitContextException(nameof(VarBinary)); }

        /// <summary>
        /// VARCHAR
        /// </summary>
        /// <returns>VARCHAR</returns>
        [ClauseStyleConverter]
        public static DataTypeElement VarChar() { throw new InvalitContextException(nameof(VarChar)); }

        /// <summary>
        /// VARCHAR
        /// </summary>
        /// <param name="n">n</param>
        /// <returns>VARCHAR</returns>
        [FuncStyleConverter]
        public static DataTypeElement VarChar(int n) { throw new InvalitContextException(nameof(VarChar)); }
    }
}
