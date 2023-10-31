using PasiekaMainProject.Annotations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PasiekaMainProject.MyEnums
{
    public enum SyurpTypeEnum
    {
        [DescriptionForForm("1 : 1")]
        OneToOne = 0,
        [DescriptionForForm("3 : 2")]
        ThreeToTwo,
        [DescriptionForForm("2 : 1")]
        TwoToOne
    }
}
