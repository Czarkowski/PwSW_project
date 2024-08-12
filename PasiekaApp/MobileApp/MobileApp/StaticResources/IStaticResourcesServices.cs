using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MobileApp.StaticResources
{
    public interface IStaticResourcesServices
    {
        Task InitializeResourcesAsync(ResourceDictionary resourceDictionary);
    }
}
