using Data.Core.Models;
using Data.Core.Services.Interfaces;
using Microsoft.Maui.Platform;
using MobileApp.Helpers.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MobileApp.Helpers
{
    public class ReviewHelper : IReviewHelper
    {
        private readonly IBeeService _beeService;
        public ReviewHelper(IBeeService beeService) 
        {
            _beeService = beeService;
        }
        public Review CompleateReview(Review review)
        {
            review.RealizedDate = DateTime.Now;
            return _beeService.UpdateReview(review);
        }
    }
}
