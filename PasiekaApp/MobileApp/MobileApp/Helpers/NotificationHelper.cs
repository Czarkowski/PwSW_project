using Data.Core.Models;
using Data.Core.Repositories.Interfaces;
using MobileApp.Helpers.Interfaces;
using MobileApp.Localizations;
using Plugin.LocalNotification;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MobileApp.Helpers
{
    public class NotificationHelper : INotificationHelper
    {
        private readonly INotificationRepository _notificationRepository;
        public NotificationHelper(INotificationRepository notificationRepository)
        {
            _notificationRepository = notificationRepository;
        }
        public void CancelNotification(Notification notification)
        {
            if (!notification.IsActivated || notification.LocalNotificationId == default)
            {
                return;
            }
            LocalNotificationCenter.Current.Cancel(notification.LocalNotificationId);
            notification.IsActivated = false;
            notification = _notificationRepository.Update(notification);
        }

        public void ScheduleNotification(Notification notification)
        {
            if (notification.IsActivated)
            {
                return;
            }
            var notificationRequest = new NotificationRequest
            {
                NotificationId = notification.Id,
                Title = notification.Title,
                Description = notification.Description,
                Schedule = new NotificationRequestSchedule
                {
                    NotifyTime = notification.NotifyTime
                }
            };
            LocalNotificationCenter.Current.Show(notificationRequest);
            notification.IsActivated = true;
            notification.LocalNotificationId = notificationRequest.NotificationId;
            notification = _notificationRepository.Update(notification);
        }

        public Notification CreateNotification(Review review, DateTime notifyTime)
        {
            // "Przypomnienie o: {0}, w dnia: {1}, opis: {2}"
            string description = string.Format(LocalizeManager.Translate("txt_ReviewNotificationDescription"),
                review.ReviewType.Name, review.PlannedDate, review.Description);
            var notification = new Notification
            {
                ReviewId = review.Id,
                Title = LocalizeManager.Translate("txt_ReviewNotificationTitle"),
                Description =description,
                NotifyTime = notifyTime
            };
            notification = _notificationRepository.Add(notification);
            return notification;
        }

        public List<Notification> CreateAndSetBaseNotificationForReview(Review review)
        {
            var not1 = CreateNotification(review, review.PlannedDate.Date.AddHours(6));
            var not2 = CreateNotification(review, review.PlannedDate.Date.AddDays(-1).AddHours(6));
            var not3 = CreateNotification(review, DateTime.Now.AddMinutes(1));
            ScheduleNotification(not3);
            ScheduleNotification(not1);
            ScheduleNotification(not2);
            return new List<Notification> { not1, not2 };
        }
    }
}
