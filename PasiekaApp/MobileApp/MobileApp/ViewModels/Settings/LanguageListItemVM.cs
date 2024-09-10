using MobileApp.ViewModels.BaseViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MobileApp.ViewModels
{
    public class LanguageListItemVM : SelectableVM
    {
        private string _languageName;
        public string LanguageName { get => _languageName; set => SetProperty(ref _languageName, value); }
        private string _languageCode;
        public string LanguageCode { get => _languageCode; set => SetProperty(ref _languageCode, value); }

        public override string ToString()
        {
            return LanguageName;
        }
    }
}
