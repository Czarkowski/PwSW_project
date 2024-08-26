using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MobileApp.CommunicationMessages
{
    public class MyCustomMessage
    {
        public string Content { get; }

        public MyCustomMessage(string content)
        {
            Content = content;
        }
    }
}
