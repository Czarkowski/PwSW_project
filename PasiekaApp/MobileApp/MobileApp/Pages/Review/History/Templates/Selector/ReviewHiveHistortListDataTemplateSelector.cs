using MobileApp.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MobileApp.Pages.Review.List.Templates
{
    class ReviewHiveHistortListDataTemplateSelector : DataTemplateSelector
    {
        public DataTemplate Completed { get; set; } = new ReviewHiveHistoryListDataTemplateCompleted();
        public DataTemplate Uncompleted { get; set; } = new ReviewHiveHistoryListDataTemplateUncmopleted();
        protected override DataTemplate OnSelectTemplate(object item, BindableObject container)
        {
            if (item is ReviewHistoryListItemVM review)
            {
                if (review.RealizedDate != null)
                {
                    return Completed;
                }
                else
                {
                    return Uncompleted;
                }
            }
            else
            {
                return null;
            }
        }
    }
}
