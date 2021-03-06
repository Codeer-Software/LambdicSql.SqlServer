﻿using LambdicSql.ConverterServices.SymbolConverters;
using System;
using System.Collections.Generic;
using System.Text;

namespace LambdicSql.SqlServer
{
    /// <summary>
    /// Element of DATENAME arguments.
    /// </summary>
    [EnumToStringConverter]
    public enum DateNameElement
    {
        /// <summary>
        /// Year.
        /// </summary>
        Year,

        /// <summary>
        /// Quarter.
        /// </summary>
        Quarter,

        /// <summary>
        /// Month.
        /// </summary>
        Month,

        /// <summary>
        /// Dayofyear.
        /// </summary>
        Dayofyear,

        /// <summary>
        /// Day.
        /// </summary>
        Day,

        /// <summary>
        /// Week.
        /// </summary>
        Week,

        /// <summary>
        /// Weekday.
        /// </summary>
        Weekday,

        /// <summary>
        /// Hour.
        /// </summary>
        Hour,

        /// <summary>
        /// Minute.
        /// </summary>
        Minute,

        /// <summary>
        /// Second.
        /// </summary>
        Second,

        /// <summary>
        /// Millisecond.
        /// </summary>
        Millisecond,

        /// <summary>
        /// Microsecond.
        /// </summary>
        Microsecond,

        /// <summary>
        /// Nanosecond.
        /// </summary>
        Nanosecond,

        /// <summary>
        /// TZoffset
        /// </summary>
        TZOffset,

        /// <summary>
        /// ISO_WEEK.
        /// </summary>
        ISO_WEEK,
    }
}
