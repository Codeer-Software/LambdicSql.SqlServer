using LambdicSql.ConverterServices;
using LambdicSql.ConverterServices.SymbolConverters;
using LambdicSql.Specialized.SymbolConverters;

namespace LambdicSql.SqlServer
{
    //@@@
    /// <summary>
    /// SQL Symbol.
    /// It can only be used within methods of the LambdicSql.Db class.
    /// Use[using static LambdicSql.SqlServer.Symbol;], you can use to write natural SQL.
    /// </summary>
    public static partial class Symbol
    {
        /// <summary>
        /// DECLARE CURSOR FOR clause.
        /// </summary>
        /// <param name="vendor_cursor">vendor_cursor.</param>
        /// <returns>Clause.</returns>
        [MethodFormatConverter(Format = "DECLARE [!0] CURSOR FOR")]
        public static Clause<Non> DeclareCursorFor(string vendor_cursor) => throw new InvalitContextException(nameof(DeclareCursorFor));

        /// <summary>
        /// DECLARE CURSOR FOR clause.
        /// </summary>
        /// <typeparam name="T">The type represented by before clause.</typeparam>
        /// <param name="before">It is the previous clause.</param>
        /// <param name="vendor_cursor">vendor_cursor.</param>
        /// <returns>Clause.</returns>
        [MethodFormatConverter(Format = "DECLARE [!1] CURSOR FOR")]
        public static Clause<T> DeclareCursorFor<T>(this Clause<T> before, string vendor_cursor) => throw new InvalitContextException(nameof(DeclareCursorFor));

        /// <summary>
        /// OPEN.
        /// </summary>
        /// <param name="vendor_cursor">vendor_cursor.</param>
        /// <returns>Clause.</returns>
        [MethodFormatConverter(Format = "OPEN [!0]")]
        public static Clause<Non> Open(string vendor_cursor) => throw new InvalitContextException(nameof(Open));

        /// <summary>
        /// OPEN.
        /// </summary>
        /// <typeparam name="T">The type represented by before clause.</typeparam>
        /// <param name="before">It is the previous clause.</param>
        /// <param name="vendor_cursor ">vendor_cursor.</param>
        /// <returns>Clause.</returns>
        [MethodFormatConverter(Format = "OPEN [!1]")]
        public static Clause<T> Open<T>(this Clause<T> before, string vendor_cursor) => throw new InvalitContextException(nameof(Open));

        /// <summary>
        /// CLOSE.
        /// </summary>
        /// <param name="vendor_cursor">vendor_cursor.</param>
        /// <returns>Clause.</returns>
        [MethodFormatConverter(Format = "CLOSE [!0]")]
        public static Clause<Non> Close(string vendor_cursor) => throw new InvalitContextException(nameof(Close));

        /// <summary>
        /// CLOSE.
        /// </summary>
        /// <typeparam name="T">The type represented by before clause.</typeparam>
        /// <param name="before">It is the previous clause.</param>
        /// <param name="vendor_cursor">vendor_cursor.</param>
        /// <returns>Clause.</returns>
        [MethodFormatConverter(Format = "CLOSE [!1]")]
        public static Clause<T> Close<T>(this Clause<T> before, string vendor_cursor) => throw new InvalitContextException(nameof(Close));

        /// <summary>
        /// DEALLOCATE.
        /// </summary>
        /// <param name="vendor_cursor">vendor_cursor.</param>
        /// <returns>Clause.</returns>
        [MethodFormatConverter(Format = "DEALLOCATE [!0]")]
        public static Clause<Non> Deallocate(string vendor_cursor) => throw new InvalitContextException(nameof(Deallocate));

        /// <summary>
        /// DEALLOCATE.
        /// </summary>
        /// <typeparam name="T">The type represented by before clause.</typeparam>
        /// <param name="before">It is the previous clause.</param>
        /// <param name="vendor_cursor">vendor_cursor.</param>
        /// <returns>Clause.</returns>
        [MethodFormatConverter(Format = "DEALLOCATE [!1]")]
        public static Clause<T> Deallocate<T>(this Clause<T> before, string vendor_cursor) => throw new InvalitContextException(nameof(Deallocate));

        /// <summary>
        /// FETCH NEXT FROM INTO.
        /// </summary>
        /// <param name="vendor_cursor"></param>
        /// <param name="variables"></param>
        /// <returns></returns>
        [MethodFormatConverter(Format = "FETCH NEXT FROM [!0] INTO [<, >1]")]
        public static Clause<Non> FetchNextFromInto(string vendor_cursor, params object[] variables) => throw new InvalitContextException(nameof(FetchNextFromInto));

        /// <summary>
        /// FETCH NEXT FROM INTO.
        /// </summary>
        /// <typeparam name="T">The type represented by before clause.</typeparam>
        /// <param name="before">It is the previous clause.</param>
        /// <param name="vendor_cursor"></param>
        /// <param name="variables"></param>
        /// <returns></returns>
        [MethodFormatConverter(Format = "FETCH NEXT FROM [!1] INTO [<, >2]")]
        public static Clause<T> FetchNextFromInto<T>(this Clause<T> before, string vendor_cursor, params object[] variables) => throw new InvalitContextException(nameof(FetchNextFromInto));
    }
}