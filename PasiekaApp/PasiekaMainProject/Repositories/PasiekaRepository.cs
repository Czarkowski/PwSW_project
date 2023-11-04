using Microsoft.EntityFrameworkCore;
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

        public bool DeleteUl(int id)
        {
            var model = context.Ul.FirstOrDefault(x => x.Id == id);
            if (model == null)
                return false;

            context.Ul.Remove(model);
            context.SaveChanges() ;
            return true;
        }

        public IQueryable<UlModel> GatAllUls()
        {
            throw new NotImplementedException();
        }

        public UlModel GetUl(long id)
        {
            return context.Ul.First(x => x.Id == id);
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
            return context.Ul.Include(ul => ul.Rasa).ToList();
        }

        public List<RasaModel> GetAllRasas()
        {
            return context.Rasa.ToList();
        }

        public List<int> GetAllLockNumber()
        {
            return GetUls().Select(x => x.Numer).ToList();
        }

        public RasaModel GetRasa(string name)
        {
            return context.Rasa.Include(r => r.Uls).FirstOrDefault(x => x.Nazwa == name);
        }

        public PrzegladModel SavePrzeglad(PrzegladModel model)
        {
            model = context.Przeglad.Add(model).Entity;
            context.SaveChanges();
            return model;
        }

        public List<PrzegladModel> GetAllPrzeglads()
        {
            return context.Przeglad.Include(p => p.OpisUlPrzegladModels).ThenInclude(po => po.Ul).ToList();
        }

        public OpisUlPrzegladModel UpdateOpisUlPrzeglad(OpisUlPrzegladModel model)
        {
            model = context.OpisUlPrzeglad.Update(model).Entity;
            context.SaveChanges();
            return model;   
        }

        public PrzegladModel UpdatePrzeglad(PrzegladModel model)
        {
            model = context.Przeglad.Update(model).Entity;
            context.SaveChanges();
            return model;
        }

        public bool DeletePrzeglad(PrzegladModel model)
        {
            //var model = context.Ul.FirstOrDefault(x => x.Id == id);
            if (model == null)
                return false;

            var x = context.Przeglad.Remove(model);
            foreach (var item in model.OpisUlPrzegladModels)
            {
            context.OpisUlPrzeglad.Remove(item);
            }
            int ret = context.SaveChanges();
            return ret > 0;
        }

        public List<OpisUlPrzegladModel> GetOpisUlPrzegladsWithPrzeglad(UlModel model)
        {
            return context.OpisUlPrzeglad.Where(x => x.UlId == model.Id).Include(x => x.Przeglad).ToList();
        }

        public List<PoseModel> GetPoseModels()
        {
            return context.Pose.Include(x => x.Ul).ToList();
        }

        public void UpdatePoseModel(PoseModel model)
        {
            context.Pose.Update(model);
            context.SaveChanges();
        }

        public void SavePoseModel(PoseModel model)
        {
            context.Pose.Add(model);
            context.SaveChanges();
        }

        public void DeletePoseModel(PoseModel model)
        {
            context.Pose.Remove(model);
            context.SaveChanges();
        }
    }
}
