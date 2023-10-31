using PasiekaMainProject.Helpers;
using PasiekaMainProject.MyClassAndInterface;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

namespace PasiekaMainProject
{
    public partial class FormAcidCalc : UserControl, IRefreshCalcUserControl
    {
        public FormAcidCalc()
        {
            InitializeComponent();

        }

        public void RefreshCalc()
        {
            Control? parent = this.Parent;
            while (!parent.IsNull() && parent is not UserControl) { parent = parent?.Parent; }
            if (parent is PasiekaCalculator calculator)
            {
                calculator.GetUlsCount(out int hive, out int half);
                int brick = hive * 2 + half;
                decimal acid = brick * SpecialValues.FormAcidMultiply;
                tbBrick.Text = brick.ToString();
                tbAcid.Text = acid.ToString();
            }
        }
    }

}
