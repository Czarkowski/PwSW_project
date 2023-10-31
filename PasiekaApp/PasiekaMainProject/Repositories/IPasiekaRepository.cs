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
        UlModel GetUl(long id);
        IQueryable<UlModel> GatAllUls();
        long AddUl(UlModel model);
        UlModel UpdateUl(UlModel model, int id = default);
        bool DeleteUl(UlModel model) { return DeleteUl(model.Id); }   
        bool DeleteUl(int id);
        bool DeletePrzeglad(PrzegladModel model);
        List<UlModel> GetUls();
        List<RasaModel> GetAllRasas();
        List<int> GetAllLockNumber();
        RasaModel GetRasa(string name);
        PrzegladModel SavePrzeglad(PrzegladModel model);
        List<PrzegladModel> GetAllPrzeglads(); 
        OpisUlPrzegladModel UpdateOpisUlPrzeglad(OpisUlPrzegladModel model);
        List<OpisUlPrzegladModel> GetOpisUlPrzegladsWithPrzeglad(UlModel model);
        PrzegladModel UpdatePrzeglad(PrzegladModel model);
        //List<OpisUlPrzegladModel> GetA
    }
}
