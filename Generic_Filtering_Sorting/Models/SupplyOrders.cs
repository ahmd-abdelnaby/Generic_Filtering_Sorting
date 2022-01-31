using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace Generic_Filtering_Sorting.Models
{
    public partial class SupplyOrders
    {
        public SupplyOrders()
        {
            SupplyOrderDetails = new HashSet<SupplyOrderDetails>();
            SupplyOrderPayments = new HashSet<SupplyOrderPayments>();
        }

        public int Id { get; set; }
        public string OrderNumber { get; set; }
        public double? TotalPrice { get; set; }
        public double? ActualTotalPrice { get; set; }
        public string AssignedToId { get; set; }
        public int FromId { get; set; }
        public int ToId { get; set; }
        public string CreatedById { get; set; }
        public int OrderStateId { get; set; }
        public DateTime Created { get; set; }
        public DateTime Modified { get; set; }
        public string AcceptedById { get; set; }
        public DateTime? DeliveredOn { get; set; }
        public string ReceivedById { get; set; }
        public bool? IsDeleted { get; set; }
        public int? PaymentMethodId { get; set; }
        public bool? PaymentStatus { get; set; }
        public int? TripId { get; set; }

        public virtual AspNetUsers AcceptedBy { get; set; }
        public virtual AspNetUsers AssignedTo { get; set; }
        public virtual AspNetUsers CreatedBy { get; set; }
        public virtual Warehouses From { get; set; }
        public virtual SupplyOrderStates OrderState { get; set; }
        public virtual PaymentMethods PaymentMethod { get; set; }
        public virtual AspNetUsers ReceivedBy { get; set; }
        public virtual Warehouses To { get; set; }
        public virtual Trips Trip { get; set; }
        public virtual SupplyOrderPaymentDetails SupplyOrderPaymentDetails { get; set; }
        public virtual ICollection<SupplyOrderDetails> SupplyOrderDetails { get; set; }
        public virtual ICollection<SupplyOrderPayments> SupplyOrderPayments { get; set; }
    }
}
