using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace Generic_Filtering_Sorting.Models
{
    public partial class BankDeposit
    {
        public BankDeposit()
        {
            BillPayment = new HashSet<BillPayment>();
            ShippingOrderPaymentDetails = new HashSet<ShippingOrderPaymentDetails>();
            SupplyOrderPaymentDetails = new HashSet<SupplyOrderPaymentDetails>();
        }

        public int Id { get; set; }
        public double Value { get; set; }
        public DateTime Created { get; set; }
        public DateTime Modified { get; set; }
        public bool IsDeleted { get; set; }
        public string DepositNumber { get; set; }
        public int BankId { get; set; }

        public virtual ICollection<BillPayment> BillPayment { get; set; }
        public virtual ICollection<ShippingOrderPaymentDetails> ShippingOrderPaymentDetails { get; set; }
        public virtual ICollection<SupplyOrderPaymentDetails> SupplyOrderPaymentDetails { get; set; }
    }
}
