using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace Generic_Filtering_Sorting.Models
{
    public partial class ShippingOrder
    {
        public ShippingOrder()
        {
            ShippingOrderDetails = new HashSet<ShippingOrderDetails>();
        }

        public int Id { get; set; }
        public string OrderNumber { get; set; }
        public double? TotalPrice { get; set; }
        public int ToId { get; set; }
        public string CreatedById { get; set; }
        public DateTime Created { get; set; }
        public DateTime Modified { get; set; }
        public bool? IsDeleted { get; set; }

        public virtual AspNetUsers CreatedBy { get; set; }
        public virtual Warehouses To { get; set; }
        public virtual ShippingOrderPaymentDetails ShippingOrderPaymentDetails { get; set; }
        public virtual ICollection<ShippingOrderDetails> ShippingOrderDetails { get; set; }
    }
}
