﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1SPZ
{
    public static class AppConstants
    {
        public const int Size = 4;

        public const double ProcessReadWriteThreshold = 0.5;

        public const double ProcessWorkingSetThreshold = 0.5;

        public const int NumberOfPhysicalPages = 15;

        public const int T = 20;

        public const int MillisecondsToResetUsageBit = 600;

        public const double UpdateWorkingSetThreshold = 0.01;
    }
}
