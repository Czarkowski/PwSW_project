using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PasiekaMainProject.MyException
{
    [Serializable]
    public class NoOrBadModelValueException : Exception
    {
        public NoOrBadModelValueException(string name, object? value = null)
        : base(String.Format("No or bad valuew in model. Model: {0}, Value: {1}", name, value))
        {

        }
    }
}
