using LambdicSql.ConverterServices;
using LambdicSql.ConverterServices.SymbolConverters;
using System;

namespace LambdicSql.SqlServer
{
    public static partial class Symbol
    {
        /// <summary>
        /// DATEPART function.
        /// </summary>
        /// <param name="element">Part type.</param>
        /// <param name="src">The date data.</param>
        /// <returns>A part from the date data.</returns>
        [FuncStyleConverter]
        public static int DatePart(DateTimeElement element, DateTime src) { throw new InvalitContextException(nameof(DatePart)); }

        /*
        CURRENT_TIMESTAMP
        DATEADD
        DATEDIFF
        DATEDIFF_BIG
        DATEFROMPARTS
        DATENAME
        DATETIME2FROMPARTS
        DATETIMEFROMPARTS
        DATETIMEOFFSETFROMPARTS
        DAY
        EOMONTH
        GETDATE
        GETUTCDATE
        ISDATE
        MONTH
        SMALLDATETIMEFROMPARTS
        SWITCHOFFSET
        SYSDATETIME
        SYSDATETIMEOFFSET
        SYSUTCDATETIME
        TIMEFROMPARTS
        TODATETIMEOFFSET
        YEAR
         */
    }
}
