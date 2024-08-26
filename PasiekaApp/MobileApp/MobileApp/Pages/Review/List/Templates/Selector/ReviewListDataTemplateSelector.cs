using MobileApp.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MobileApp.Pages.Review.List.Templates
{
    class ReviewListDataTemplateSelector : DataTemplateSelector
    {
        public DataTemplate Completed { get; set; } = new ReviewListDataTemplateCompleted();
        public DataTemplate Uncompleted { get; set; } = new ReviewListDataTemplateUncmopleted();
        public DataTemplate Soon { get; set; } = new ReviewListDataTemplateSoon();
        protected override DataTemplate OnSelectTemplate(object item, BindableObject container)
        {
            if (item is ReviewListItemVM review)
            {
                if (review.RealizedDate != null)
                {
                    return Completed;
                }
                else if (review.PlannedDate < (DateTime.Now.Date.AddDays(-1)))
                {
                    return Soon;
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
