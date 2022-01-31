using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace Generic_Filtering_Sorting.Models
{
    public partial class Bills
    {
        public Bills()
        {
            BillDetails = new HashSet<BillDetails>();
        }

        public int Id { get; set; }
        public string BillNumber { get; set; }
        public double? TotalPrice { get; set; }
        public string OrderNumber { get; set; }
        public int MerchantId { get; set; }
        public int PaymentMethodId { get; set; }
        public string CreatedBy { get; set; }
        public DateTime Created { get; set; }
        public DateTime Modified { get; set; }
        public bool? PaymentStatus { get; set; }
        public bool? IsDeleted { get; set; }

        public virtual AspNetUsers CreatedByNavigation { get; set; }
        public virtual Merchants Merchant { get; set; }
        public virtual PaymentMethods PaymentMethod { get; set; }
        public virtual BillPayment BillPayment { get; set; }
        public virtual ICollection<BillDetails> BillDetails { get; set; }
    }
}
