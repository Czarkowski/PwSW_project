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
    }
}
