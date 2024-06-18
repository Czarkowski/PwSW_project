using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MobileApp.Droid
{
public class SqlitePlatformPath_Android : ISqlitePlatformPath
    {
        public string GetDatabasePath(string dbName)
        {
            return Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Personal), dbName);
        }
    }

}
