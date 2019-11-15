using System;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

namespace BCX
{
    public class BCXWrapperBase
    {
        public static string VERSION = "0.0.2";
        public delegate void BCXEventHandler(string evt, string json);

        protected static List<string> str2list(string str)
        {
            return str.Split(',').Select(p => p.Trim()).ToList();
        }

        protected static bool IsNumber(object value)
        {
            return value is sbyte
                    || value is byte
                    || value is short
                    || value is ushort
                    || value is int
                    || value is uint
                    || value is long
                    || value is ulong
                    || value is float
                    || value is double
                    || value is decimal;
        }
    }
}

