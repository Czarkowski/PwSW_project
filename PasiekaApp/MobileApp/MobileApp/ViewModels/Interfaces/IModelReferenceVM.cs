using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MobileApp.ViewModels.Interfaces
{
    public interface IModelReferenceVM<T> where T : Data.Core.Models.BaseModel
    {
        public T Model { get; }
    }
}
