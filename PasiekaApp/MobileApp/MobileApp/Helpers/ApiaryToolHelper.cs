using MobileApp.ApiaryTools;
using MobileApp.Core.Classes;
using MobileApp.Helpers.Interfaces;
using MobileApp.Localizations;
using MobileApp.Utilities.StaticExtensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MobileApp.Helpers
{
    public class ApiaryToolHelper : IApiaryToolHelper
    {
        public List<NamedValue<SyrupCalculationBaseType>> GetAllSyrupCalculationBaseType()
        {
            var enumValues = Enum.GetValues<SyrupCalculationBaseType>().ToList();
            return enumValues.Select(x => new NamedValue<SyrupCalculationBaseType>(
                x, LocalizeManager.Translate(x.GetDescription()))).ToList();
        }

        public List<NamedValue<SyrupCalculationRatioType>> GetSyrupCalculationRatioType()
        {
            var enumValues = Enum.GetValues<SyrupCalculationRatioType>().ToList();
            return enumValues.Select(x => new NamedValue<SyrupCalculationRatioType>(
                x, LocalizeManager.Translate(x.GetDescription()))).ToList();
        }
    }
}
