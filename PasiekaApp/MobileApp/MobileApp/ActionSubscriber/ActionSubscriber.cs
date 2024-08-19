using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MobileApp.ActionSubscriber
{
    public class ActionSubscriber<TSender> : IDisposable
        where TSender : class
    {
        private readonly object _subscriber;
        private readonly string _message;

        public ActionSubscriber(object subscriber, string message, Action<TSender> callback)
        {
            _subscriber = subscriber;
            _message = message;

            MessagingCenter.Subscribe(subscriber, message, callback);
        }

        public void Dispose()
        {
            MessagingCenter.Unsubscribe<TSender>(_subscriber, _message);
        }

        public static void DoAction(TSender sender, string message)
        {
            MessagingCenter.Send(sender, message);
        }
    }
}
