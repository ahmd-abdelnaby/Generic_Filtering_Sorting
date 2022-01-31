using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace Generic_Filtering_Sorting.Models
{
    public partial class Trips
    {
        public Trips()
        {
            SupplyOrders = new HashSet<SupplyOrders>();
        }

        public int Id { get; set; }
        public string TripNumber { get; set; }
        public string AssignedToId { get; set; }
        public int FromId { get; set; }
        public string CreatedById { get; set; }
        public int TripStateId { get; set; }
        public string AcceptedById { get; set; }
        public DateTime? DeliveredOn { get; set; }
        public DateTime Created { get; set; }
        public DateTime Modified { get; set; }
        public bool? IsDeleted { get; set; }

        public virtual AspNetUsers AcceptedBy { get; set; }
        public virtual AspNetUsers AssignedTo { get; set; }
        public virtual AspNetUsers CreatedBy { get; set; }
        public virtual Warehouses From { get; set; }
        public virtual TripState TripState { get; set; }
        public virtual ICollection<SupplyOrders> SupplyOrders { get; set; }
    }
}
