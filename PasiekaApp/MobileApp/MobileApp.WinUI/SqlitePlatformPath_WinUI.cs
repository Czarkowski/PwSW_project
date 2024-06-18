using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MobileApp.WinUI
{
    public class SqlitePlatformPath_WinUI : ISqlitePlatformPath
    {
        public string GetDatabasePath(string dbName)
        {
            return Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), dbName);
        }
    }
}
