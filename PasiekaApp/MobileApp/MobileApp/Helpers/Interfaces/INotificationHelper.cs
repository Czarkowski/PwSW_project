using Data.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MobileApp.Helpers.Interfaces
{
    public interface INotificationHelper
    {
        void ScheduleNotification(Notification notification);
        void CancelNotification(Notification notification);
        Notification CreateNotification(Review review, DateTime notifyTime);
        List<Notification> CreateAndSetBaseNotificationForReview(Review review);
    }
}
