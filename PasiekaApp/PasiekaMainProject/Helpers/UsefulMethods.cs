using PasiekaMainProject.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PasiekaMainProject.Helpers
{
    public static class UsefulMethods
    {
        public static int UlComparator(UlModel ul1, UlModel ul2)
        {
            return ul1.Numer.CompareTo(ul2.Numer);
        }
    }
}
