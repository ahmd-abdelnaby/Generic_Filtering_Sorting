using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace Generic_Filtering_Sorting.Models
{
    public partial class DailyReports
    {
        public DailyReports()
        {
            DailyReportDetails = new HashSet<DailyReportDetails>();
        }

        public int Id { get; set; }
        public double SalesTotal { get; set; }
        public double StoreTreasure { get; set; }
        public double OtherWarehouses { get; set; }
        public double BankDeposits { get; set; }
        public double Discounts { get; set; }
        public double TotalPayments { get; set; }
        public int WarehouseId { get; set; }
        public string UserId { get; set; }
        public DateTime Created { get; set; }
        public DateTime Modified { get; set; }
        public bool? IsDeleted { get; set; }

        public virtual AspNetUsers User { get; set; }
        public virtual Warehouses Warehouse { get; set; }
        public virtual ICollection<DailyReportDetails> DailyReportDetails { get; set; }
    }
}
