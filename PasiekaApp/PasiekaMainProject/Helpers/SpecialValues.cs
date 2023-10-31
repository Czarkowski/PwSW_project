using PasiekaMainProject.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PasiekaMainProject.Helpers
{
    public static class SpecialValues
    {
        public static readonly int NoBeeQueenID = 7;
        public static readonly int MinHiveNumber = 1;
        public static readonly DateTime MinDateTime = new DateTime(2000,1,1);

        public static readonly decimal OneToOneWaterToSyurpMultiply = 1.6M;
        public static readonly decimal ThreeToTwoWaterToSyurpMultiply = 2M;
        public static readonly decimal TwoToOneWaterToSyurpMultiply = 2.25M;

        public static readonly decimal OneToOneWaterToSugarMultiply = 1M;
        public static readonly decimal ThreeToTwoWaterToSugarMultiply = 1.5M;
        public static readonly decimal TwoToOneWaterToSugarpMultiply = 2M;

        public static readonly decimal FormAcidMultiply = 15M;

    }
}
