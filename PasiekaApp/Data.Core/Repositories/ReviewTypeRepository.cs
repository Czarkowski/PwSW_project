using Data.Core.Models;
using Data.Core.Repositories.Interfaces;
using Data.Core.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Core.Repositories
{
    public class ReviewTypeRepository : BaseRepository<ReviewType>, IReviewTypeRepository
    {
        public ReviewTypeRepository(BeeDbContext beeDbContext) : base(beeDbContext, beeDbContext.ReviewTypes) 
        {
        }
    }
}
