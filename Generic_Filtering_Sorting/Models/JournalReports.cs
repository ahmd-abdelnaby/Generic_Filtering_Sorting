using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace Generic_Filtering_Sorting.Models
{
    public partial class JournalReports
    {
        public int Id { get; set; }
        public string Statement { get; set; }
        public double? Company { get; set; }
        public double? Treasury { get; set; }
        public double? Goods { get; set; }
        public double? Debts { get; set; }
        public double? SubWarehouses { get; set; }
        public int WarehouseId { get; set; }
        public DateTime Created { get; set; }
        public DateTime Modified { get; set; }
        public bool? IsDeleted { get; set; }
        public double? OtherWarehouse { get; set; }
        public double? OtherDebts { get; set; }
        public bool? CompanyIsBlue { get; set; }
        public bool? DebtsIsBlue { get; set; }
        public bool? GoodsIsBlue { get; set; }
        public bool? OtherDebtsIsBlue { get; set; }
        public bool? OtherWarehouseIsBlue { get; set; }
        public bool? SubWarehousesIsBlue { get; set; }
        public bool? TreasuryIsBlue { get; set; }

        public virtual Warehouses Warehouse { get; set; }
    }
}
