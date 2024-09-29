using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Core.Models
{
    public class Notification : BaseModel
    {
        public int ReviewId { get; set; }
        public int LocalNotificationId { get; set; }
        public bool IsActivated { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public virtual Review Review { get; set; }
        public DateTime NotifyTime { get; set; }
    }
}
