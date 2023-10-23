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

        public IQueryable<UlModel> GatAllUls()
        {
            throw new NotImplementedException();
        }

        public UlModel GetUl(long id)
        {
            throw new NotImplementedException();
        }

        public UlModel UpdateUl(UlModel model, int id = default)
        {
            if (id != default)
            {
                model = new UlModel(id, model);
            }
            model = context.Ul.Update(model).Entity;
            context.SaveChanges();
            return model;

        }

        public List<UlModel> GetUls()
        {
            return context.Ul.ToList();
        }

        public List<RasaModel> GetAllRasas()
        {
            return context.Rasa.ToList();
        }
    }
}
