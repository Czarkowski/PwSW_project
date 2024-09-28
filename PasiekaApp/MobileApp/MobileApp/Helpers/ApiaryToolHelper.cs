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
        public (double, double, double) CalculateSyrup(double targetValue, SyrupCalculationBaseType baseType, SyrupCalculationRatioType ratioType)
        {
            Func<double> waterFunc = null;
            Func<double> syrupFunc = null;
            Func<double> sugarFunc = null;
            switch (ratioType)
            {
                case SyrupCalculationRatioType.OneToOne:
                    switch (baseType)
                    {
                        case SyrupCalculationBaseType.ForSugar:
                            waterFunc = () => targetValue;
                            break;
                        case SyrupCalculationBaseType.ForSyrup:
                            waterFunc = () => targetValue / 1.6;
                            break;
                    }
                    syrupFunc = () => waterFunc.Invoke() * 1.6;
                    sugarFunc = () => waterFunc.Invoke();
                    break;
                case SyrupCalculationRatioType.TwoToOne:
                    switch (baseType)
                    {
                        case SyrupCalculationBaseType.ForSugar:
                            waterFunc = () => targetValue / 2;
                            break;
                        case SyrupCalculationBaseType.ForSyrup:
                            waterFunc = () => targetValue / 2.40;
                            break;
                    }
                    syrupFunc = () => waterFunc.Invoke() * 2.40;
                    sugarFunc = () => waterFunc.Invoke() * 2;
                    break;
                case SyrupCalculationRatioType.ThreeToTwo:
                    switch (baseType)
                    {
                        case SyrupCalculationBaseType.ForSugar:
                            waterFunc = () => targetValue * 2 / 3;
                            break;
                        case SyrupCalculationBaseType.ForSyrup:
                            waterFunc = () => targetValue / 2;
                            break;
                    }
                    syrupFunc = () => waterFunc.Invoke() * 2;
                    sugarFunc = () => waterFunc.Invoke() * 3 / 2;
                    break;
            }
            return (waterFunc(), sugarFunc(), syrupFunc());
        }

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
