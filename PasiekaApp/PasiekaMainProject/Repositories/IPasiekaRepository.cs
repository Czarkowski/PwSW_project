using PasiekaMainProject.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace PasiekaMainProject.Repositories
{
    public interface IPasiekaRepository
    {
        UlModel GetUlModel(long id);
        IQueryable<UlModel> GatAllUl();
        long AddUl(UlModel model);
        UlModel UpdateUl(UlModel model, int id = default);
        bool DeleteUl(UlModel model) { return DeleteUl(model.Id); }   
        bool DeleteUl(long id);
        public List<UlModel> GetUlModels();

    }
}
