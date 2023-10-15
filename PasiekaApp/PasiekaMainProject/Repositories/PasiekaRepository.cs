using PasiekaMainProject.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PasiekaMainProject.Repositories
{
    public class PasiekaRepository : IPasiekaRepository
    {
        private readonly MyDbContext context;

        public PasiekaRepository(MyDbContext context)
        {
            this.context = context;
        }

        public long AddUl(UlModel model)
        {
            context.Ul.Add(model);
            context.SaveChanges();
            return model.Id;
        }

        public bool DeleteUl(long id)
        {
            throw new NotImplementedException();
        }

        public IQueryable<UlModel> GatAllUl()
        {
            throw new NotImplementedException();
        }

        public UlModel GetUlModel(long id)
        {
            throw new NotImplementedException();
        }

        public UlModel UpdateUl(UlModel model, long id = 0)
        {
            throw new NotImplementedException();
        }
    }
}
