using CommunityToolkit.Mvvm.Messaging;
using MobileApp.ReferenceMessenger.Messages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.ObjectiveC;
using System.Text;
using System.Threading.Tasks;

namespace MobileApp.ReferenceMessenger
{
    public class MessageCenter
    {
        public static void RefresReviewList(RefreshReviewListMessage refreshReviewListMessage = null)
        {
            WeakReferenceMessenger.Default.Send(refreshReviewListMessage ?? new RefreshReviewListMessage());
        }
        public static void SetRefresReviewList(object recipient, Action<RefreshReviewListMessage> action)
        {
            WeakReferenceMessenger.Default.Register<RefreshReviewListMessage>(recipient, (r, a) => action(a));
        }
    }
}
