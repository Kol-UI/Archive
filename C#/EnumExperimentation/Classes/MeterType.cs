﻿using System;
namespace TempoProject.Classes
{
    public class MeterType
    {
        public const int Water = 1001;
        public const int Electricity = 1004;
        public const int Gas = 1007;

        public class Waters
        {
            public const int DrinkingWater = 1002;
            public const int UsageWater = 1003;
        }

        public class Gases
        {
            public const int SubsidiseGas = 1008;
            public const int NonSusbsidisedGas = 1009;
        }
    }
}

