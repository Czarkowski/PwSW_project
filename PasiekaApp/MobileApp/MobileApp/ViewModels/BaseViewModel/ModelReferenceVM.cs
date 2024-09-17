using Data.Core.Models;
using MobileApp.ViewModels.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MobileApp.ViewModels.BaseViewModel
{
    public class ModelReferenceVM<T> : BaseVM, IModelReferenceVM<T> where T : BaseModel
    {
        private T _model;
        public T Model { get => _model; protected set => _model = value; }
        public ModelReferenceVM(T model) : base(model.Id) 
        { 
            Model = model; 
        }
    }
}
