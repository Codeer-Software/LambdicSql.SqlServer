using LambdicSql.ConverterServices;
using LambdicSql.ConverterServices.SymbolConverters;
using System;

namespace LambdicSql.SqlServer
{
    //@@@
    public static partial class Symbol
    {
        /// <summary>
        /// @@CONNECTIONS
        /// https://docs.microsoft.com/en-us/sql/t-sql/functions/dbts-transact-sql
        /// </summary>
        /// <returns></returns>
        [ClauseStyleConverter(Name = "@@CONNECTIONS")]
        public static int AtAtConnections() => throw new InvalitContextException(nameof(AtAtConnections));

        /// <summary>
        /// @@CPU_BUSY
        /// https://docs.microsoft.com/ja-jp/sql/t-sql/functions/cpu-busy-transact-sql
        /// </summary>
        /// <returns></returns>
        [ClauseStyleConverter(Name = "@@CPU_BUSY")]
        public static int AtAtCpuBusy() => throw new InvalitContextException(nameof(AtAtCpuBusy));

        /// <summary>
        /// @@IDLE
        /// https://docs.microsoft.com/ja-jp/sql/t-sql/functions/idle-transact-sql
        /// </summary>
        /// <returns></returns>
        [ClauseStyleConverter(Name = "@@IDLE")]
        public static int AtAtIdle() => throw new InvalitContextException(nameof(AtAtIdle));

        /// <summary>
        /// @@IO_BUSY
        /// https://docs.microsoft.com/ja-jp/sql/t-sql/functions/io-busy-transact-sql
        /// </summary>
        /// <returns></returns>
        [ClauseStyleConverter(Name = "@@IO_BUSY")]
        public static int AtAtIoBusy() => throw new InvalitContextException(nameof(AtAtIoBusy));

        /// <summary>
        /// @@PACK_SENT
        /// https://docs.microsoft.com/ja-jp/sql/t-sql/functions/pack-sent-transact-sql
        /// </summary>
        /// <returns></returns>
        [ClauseStyleConverter(Name = "@@PACK_SENT")]
        public static int AtAtPackSent() => throw new InvalitContextException(nameof(AtAtPackSent));

        /// <summary>
        /// @@PACKET_ERRORS
        /// https://docs.microsoft.com/ja-jp/sql/t-sql/functions/packet-errors-transact-sql
        /// </summary>
        /// <returns></returns>
        [ClauseStyleConverter(Name = "@@PACKET_ERRORS")]
        public static int AtAtPackErrors() => throw new InvalitContextException(nameof(AtAtPackErrors));

        /// <summary>
        /// @@TIMETICKS
        /// https://docs.microsoft.com/ja-jp/sql/t-sql/functions/timeticks-transact-sql
        /// </summary>
        /// <returns></returns>
        [ClauseStyleConverter(Name = "@@TIMETICKS")]
        public static int AtAtTimeTicks() => throw new InvalitContextException(nameof(AtAtTimeTicks));

        /// <summary>
        /// @@TOTAL_ERRORS
        /// https://docs.microsoft.com/ja-jp/sql/t-sql/functions/total-errors-transact-sql
        /// </summary>
        /// <returns></returns>
        [ClauseStyleConverter(Name = "@@TOTAL_ERRORS")]
        public static int AtAtTotalErrors() => throw new InvalitContextException(nameof(AtAtTotalErrors));

        /// <summary>
        /// @@TOTAL_READ
        /// https://docs.microsoft.com/ja-jp/sql/t-sql/functions/total-read-transact-sql
        /// </summary>
        /// <returns></returns>
        [ClauseStyleConverter(Name = "@@TOTAL_READ")]
        public static int AtAtTotalRead() => throw new InvalitContextException(nameof(AtAtTotalRead));

        /// <summary>
        /// @@TOTAL_WRITE
        /// https://docs.microsoft.com/ja-jp/sql/t-sql/functions/total-write-transact-sql
        /// </summary>
        /// <returns></returns>
        [ClauseStyleConverter(Name = "@@TOTAL_WRITE")]
        public static int AtAtTotalWrite() => throw new InvalitContextException(nameof(AtAtTotalWrite));
    }
}
