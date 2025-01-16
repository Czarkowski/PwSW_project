using MobileApp.Localizations;
using MobileApp.Productions;
using MobileApp.ViewModels.BaseViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MobileApp.ViewModels
{
    public class ApiaryProductionSummaryListItemVM :BaseVM
    {
        public DateTime Date { get; set; }
        public decimal Value { get; set; }
        public string Unit { get; set; }
        public string TranslateUnit => LocalizeManager.Translate(Unit);
        public string ProductionType { get; set; }
        public List<int> HiveNumbers { get; set; }
        public string HiveNumbersString => string.Join(", ", HiveNumbers);
    }
}
