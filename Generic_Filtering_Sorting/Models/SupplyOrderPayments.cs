using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace Generic_Filtering_Sorting.Models
{
    public partial class SupplyOrderPayments
    {
        public int Id { get; set; }
        public int SupplyOrderId { get; set; }
        public string UserId { get; set; }
        public string Transaction { get; set; }
        public DateTime Created { get; set; }
        public DateTime Modified { get; set; }
        public bool? IsDeleted { get; set; }

        public virtual SupplyOrders SupplyOrder { get; set; }
        public virtual AspNetUsers User { get; set; }
    }
}
