using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace Generic_Filtering_Sorting.Models
{
    public partial class Notifications
    {
        public int Id { get; set; }
        public int NotificationId { get; set; }
        public DateTime Created { get; set; }
        public DateTime Modified { get; set; }
        public bool? IsDeleted { get; set; }
        public string Body { get; set; }
        public bool? IsRead { get; set; }
        public string OrderNumber { get; set; }
        public string Title { get; set; }
        public string UserId { get; set; }
        public int CreatedTimestamp { get; set; }

        public virtual NotificationTypes Notification { get; set; }
        public virtual AspNetUsers User { get; set; }
    }
}
