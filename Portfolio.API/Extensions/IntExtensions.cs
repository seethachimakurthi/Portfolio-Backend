﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Portfolio.API.Extensions
{
    public static class IntExtensions
    {
        public static bool IsBetween(this int num, int low, int high)
        {
            return num >= low && num <= high;
        }

        public static bool IsOdd(this int value)
        {
            return value % 2 != 0;
        }

        public static bool IsEven(this int value)
        {
            return value % 2 == 0;
        }
    }
}
