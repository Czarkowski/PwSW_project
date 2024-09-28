using MobileApp.ApiaryTools;
using MobileApp.Core.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MobileApp.Helpers.Interfaces
{
    public interface IApiaryToolHelper
    {
        List<NamedValue<SyrupCalculationBaseType>> GetAllSyrupCalculationBaseType();
        List<NamedValue<SyrupCalculationRatioType>> GetSyrupCalculationRatioType();

        /// <summary>
        /// 
        /// </summary>
        /// <param name="targetValue"></param>
        /// <param name="baseType"></param>
        /// <param name="ratioType"></param>
        /// <returns>First: Water; Second: Sugar; Third: Syrup</returns>
        (double, double, double) CalculateSyrup(double targetValue, SyrupCalculationBaseType baseType, SyrupCalculationRatioType ratioType);
    }
}
