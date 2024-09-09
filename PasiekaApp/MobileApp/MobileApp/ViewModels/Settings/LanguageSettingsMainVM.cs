using MobileApp.ViewModels.BaseViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MobileApp.ViewModels
{
    public class LanguageSettingsMainVM : BaseVM
    {
        private LanguageListVM _languageListVM;
        public LanguageListVM LanguageListVM
        {
            get => _languageListVM;
            set => SetProperty(ref _languageListVM, value);
        }
    }
}
