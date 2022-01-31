﻿using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace Generic_Filtering_Sorting.Models
{
    public partial class BillPayment
    {
        public int Id { get; set; }
        public int BankDepositId { get; set; }
        public double WarehouseCash { get; set; }
        public double OtherWarehousesCash { get; set; }
        public double MonthcommercialDiscount { get; set; }
        public double PromotionalDiscount { get; set; }
        public double FinancialDisclosure { get; set; }
        public DateTime Created { get; set; }
        public DateTime Modified { get; set; }
        public bool? IsDeleted { get; set; }
        public int BillId { get; set; }
        public double CarHelp { get; set; }

        public virtual BankDeposit BankDeposit { get; set; }
        public virtual Bills Bill { get; set; }
    }
}
