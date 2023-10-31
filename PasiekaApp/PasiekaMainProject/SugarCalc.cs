using PasiekaMainProject.Helpers;
using PasiekaMainProject.MyClassAndInterface;
using PasiekaMainProject.MyEnums;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PasiekaMainProject
{
    public partial class SugarCalc : UserControl, IRefreshCalcUserControl
    {
        private string trackBarText = "Mnożnik dla odkładu ({0})";

        public delegate bool GetHiveQuantity(out int hive, out int halfHive);
        public GetHiveQuantity getHiveQuantity { get; set; }
        private decimal inValue;
        public SugarCalc(GetHiveQuantity getHiveQuantity)
        {
            this.getHiveQuantity = getHiveQuantity;
            InitializeComponent();
        }

        private void SugarCalc_Load(object sender, EventArgs e)
        {
            var enumValuesBase = Enum.GetValues(typeof(BaseElementSyurpEnum)).Cast<BaseElementSyurpEnum>().ToList();
            cbElementType.DataSource = enumValuesBase;

            var enumValuesSyurp = Enum.GetValues(typeof(SyurpTypeEnum)).Cast<SyurpTypeEnum>().ToList();

            cbSyurpType.DataSource = DSModelForComboBox<SyurpTypeEnum>.GetDSList(enumValuesSyurp, x => StaticExtensions.GetDescription(x));

            cbSyurpType.ValueMember = "Value";
            cbSyurpType.DisplayMember = "Name";


            lblTrB.Text = string.Format(trackBarText, ((decimal)tbMultiply.Value / 10).ToString("N1"));
        }

        public virtual void RefreshCalc()
        {
            SyurpTypeEnum? selectedSyurpType = cbSyurpType.SelectedValue as SyurpTypeEnum?;
            BaseElementSyurpEnum? selectedElementType = cbElementType.SelectedValue as BaseElementSyurpEnum?;
            decimal multiplyWaterToSyurp;
            decimal multiplyWaterToSugar;

            switch (selectedSyurpType)
            {
                case SyurpTypeEnum.OneToOne:
                    multiplyWaterToSyurp = SpecialValues.OneToOneWaterToSyurpMultiply;
                    multiplyWaterToSugar = SpecialValues.OneToOneWaterToSugarMultiply;
                    break;
                case SyurpTypeEnum.ThreeToTwo:
                    multiplyWaterToSyurp = SpecialValues.ThreeToTwoWaterToSyurpMultiply;
                    multiplyWaterToSugar = SpecialValues.ThreeToTwoWaterToSugarMultiply;
                    break;
                case SyurpTypeEnum.TwoToOne:
                    multiplyWaterToSyurp = SpecialValues.TwoToOneWaterToSyurpMultiply;
                    multiplyWaterToSugar = SpecialValues.TwoToOneWaterToSugarpMultiply;
                    break;
                case null:
                default:
                    return;
            }

            decimal desiredValue = inValue;

            if (chbPerHive.Checked && !getHiveQuantity.IsNull())
            {
                int hive;
                int halfHive;
                getHiveQuantity.Invoke(out hive, out halfHive);
                desiredValue = inValue * hive + inValue * halfHive * (decimal)tbMultiply.Value / 10M;

            }
            decimal water = default;
            decimal sugar = default;
            decimal syurp = default;
            decimal acid = default;
            decimal probio = default;
            switch (selectedElementType)
            {
                case BaseElementSyurpEnum.Syrop:
                    syurp = desiredValue;
                    water = desiredValue / multiplyWaterToSyurp;
                    sugar = water * multiplyWaterToSugar;
                    break;
                case BaseElementSyurpEnum.Cukier:
                    sugar = desiredValue;
                    water = desiredValue / multiplyWaterToSugar;
                    syurp = water * multiplyWaterToSyurp;
                    break;
                case null:
                default:
                    return;
            }

            acid = sugar;
            probio = syurp * 20;
            tbOutSugar.Text = sugar.ToString("N2");
            tbOutSyurp.Text = syurp.ToString("N2");
            tbOutWater.Text = water.ToString("N2");
            tbOutCitricAcid.Text = acid.ToString("N2");
            tbOutProbio.Text = probio.ToString("N2");
        }

        private void cbElementType_SelectedIndexChanged(object sender, EventArgs e)
        {
            RefreshCalc();
        }

        private void cbSyurpType_SelectedIndexChanged(object sender, EventArgs e)
        {
            RefreshCalc();
        }

        private void tbIn_Leave(object sender, EventArgs e)
        {
            if (Decimal.TryParse(tbIn.Text, out decimal val))
            {
                inValue = val;
                tbIn.Text = val.ToString();
                RefreshCalc();
            }
            else
            {
                tbIn.Text = inValue.ToString();
            }

        }

        private void tbIn_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
                tbIn_Leave(sender, e);
        }

        private void chbPerHive_CheckedChanged(object sender, EventArgs e)
        {
            RefreshCalc();
        }

        private void tbMultiply_ValueChanged(object sender, EventArgs e)
        {
            lblTrB.Text = string.Format(trackBarText, ((decimal)tbMultiply.Value / 10).ToString("N1"));
            RefreshCalc();
        }
    }
}
