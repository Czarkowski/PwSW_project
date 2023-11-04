using SingletonLib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PasiekaMainProject.MyClassAndInterface
{
    public class SingletonPasiekaGrid : Singleton<PasiekaGrid>
    {
    }
    public class SingletonPasiekaMap : Singleton<PasiekaMap>
    {
    }
    public class SingletonPasiekaOverview : Singleton<PasiekaOverview>
    {
    }
    public class SingletonPasiekaCalculator : Singleton<PasiekaCalculator>
    {
    }
}
