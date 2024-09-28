using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MobileApp.Productions
{
    public enum UnitType
    {
        [Description("txt_MassUnit")]
        Mass,
        [Description("txt_VolumeUnit")]
        Volume,
        [Description("txt_CountableUnit")]
        Countable
    }
}
