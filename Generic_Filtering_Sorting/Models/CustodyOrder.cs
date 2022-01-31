using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace Generic_Filtering_Sorting.Models
{
    public partial class CustodyOrder
    {
        public CustodyOrder()
        {
            CustodyAttachment = new HashSet<CustodyAttachment>();
            CustodyOrderDetails = new HashSet<CustodyOrderDetails>();
            CustodyOrderMerchants = new HashSet<CustodyOrderMerchants>();
        }

        public int Id { get; set; }
        public string OrderNumber { get; set; }
        public double? TotalPrice { get; set; }
        public double? ActualTotalPrice { get; set; }
        public string AssignedToId { get; set; }
        public string CreatedById { get; set; }
        public int StateId { get; set; }
        public DateTime Created { get; set; }
        public DateTime Modified { get; set; }
        public double TotalCash { get; set; }
        public double TotalCashless { get; set; }
        public bool? IsDeleted { get; set; }

        public virtual AspNetUsers AssignedTo { get; set; }
        public virtual AspNetUsers CreatedBy { get; set; }
        public virtual CustodyOrderStates State { get; set; }
        public virtual ICollection<CustodyAttachment> CustodyAttachment { get; set; }
        public virtual ICollection<CustodyOrderDetails> CustodyOrderDetails { get; set; }
        public virtual ICollection<CustodyOrderMerchants> CustodyOrderMerchants { get; set; }
    }
}
