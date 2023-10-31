using PasiekaMainProject.Helpers;
using PasiekaMainProject.MyClassAndInterface;
using PasiekaMainProject.MyEnums;
using PasiekaMainProject.Repositories;
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
    public partial class PasiekaCalculator : UserControl
    {

        private IRefreshCalcUserControl currentControl;
        private IPasiekaRepository repository;

        public PasiekaCalculator()
        {
            InitializeComponent();
            repository = new PasiekaRepository(MyDbContext.Instance);
        }

        public bool GetUlsCount(out int hive, out int half)
        {
            hive = (int)nudHive.Value;
            half = (int)nudHalf.Value;
            return chbAllHive.Checked;
        }
        private void PasiekaCalculator_Load(object sender, EventArgs e)
        {
            var enumValues = Enum.GetValues(typeof(CalcTypeEnum)).Cast<CalcTypeEnum>().ToList();
            cbCalcType.DataSource = enumValues;
        }

        private void cbCalcType_SelectedIndexChanged(object sender, EventArgs e)
        {
            CalcTypeEnum? selected = cbCalcType.SelectedValue as CalcTypeEnum?;
            chbAllHive.Enabled = true;
            UserControl? uc = null;
            switch (selected)
            {
                case CalcTypeEnum.Syrop:
                    uc = new SugarCalc(this.GetUlsCount);
                    break;
                case CalcTypeEnum.KwasMrowkowy:
                    uc = new FormAcidCalc();
                    break;
                case CalcTypeEnum.WymianaMatek:
                    uc = new QueenCalc();
                    chbAllHive.Checked = true;
                    chbAllHive.Enabled = false;
                    break;
                case CalcTypeEnum.None:
                case null:
                    uc = null;
                    break;
            }
            panelCalc.Controls.Clear();
            if (!uc.IsNull())
            {
                panelCalc.Controls.Add(uc);
                uc.Anchor = AnchorStyles.None;
                currentControl = uc as IRefreshCalcUserControl;
                currentControl?.RefreshCalc();
            }

        }

        private void chbAllHive_CheckedChanged(object sender, EventArgs e)
        {
            if (chbAllHive.Checked)
            {
                var uls = repository.GetUls();
                int hiveCount = uls.Where(ul => !ul.CzyOdklad).Count();
                int halfCount = uls.Where(ul => ul.CzyOdklad).Count();
                nudHive.Value = hiveCount;
                nudHalf.Value = halfCount;
                nudHive.Enabled = false;
                nudHalf.Enabled = false;
            }
            else
            {
                nudHive.Enabled = true;
                nudHalf.Enabled = true;
            }


        }

        private void nudHive_ValueChanged(object sender, EventArgs e)
        {
            currentControl?.RefreshCalc();
        }

        private void nudHalf_ValueChanged(object sender, EventArgs e)
        {
            currentControl?.RefreshCalc();
        }
    }
}
