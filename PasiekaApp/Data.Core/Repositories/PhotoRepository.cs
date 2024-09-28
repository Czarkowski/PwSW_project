using Data.Core.Models;
using Data.Core.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Core.Repositories
{
    public class PhotoRepository : BaseRepository<Photo>, IPhotoRepository
    {
        public PhotoRepository(BeeDbContext beeDbContext) : base(beeDbContext, beeDbContext.Photos)
        {
        }
    }
}
