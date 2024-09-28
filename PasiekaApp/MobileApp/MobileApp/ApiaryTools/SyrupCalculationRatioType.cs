using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MobileApp.ApiaryTools
{
    public enum SyrupCalculationRatioType
	{
		[Description("txt_OneToOne")]
		OneToOne,
		[Description("txt_TwoToOne")]
		TwoToOne,
		[Description("txt_ThreeToTwo")]
		ThreeToTwo,
    }
}
