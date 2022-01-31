using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace Generic_Filtering_Sorting.Models
{
    public partial class StockReports
    {
        public int Id { get; set; }
        public int MonthlyNeeds { get; set; }
        public double ProductionCostPrice { get; set; }
        public double SalesTax { get; set; }
        public double Insurance { get; set; }
        public double Price { get; set; }
        public int IncomingFactories { get; set; }
        public int IncomingBranches { get; set; }
        public int IncomingTotal { get; set; }
        public int OutgoingSales { get; set; }
        public int OutgoingTransfers { get; set; }
        public int OutgoingAds { get; set; }
        public int OutgoingDefects { get; set; }
        public int WarehouseId { get; set; }
        public int ProductId { get; set; }
        public DateTime Created { get; set; }
        public DateTime Modified { get; set; }
        public bool? IsDeleted { get; set; }
        public int OutgoingTotal { get; set; }
        public int Balance { get; set; }

        public virtual Products Product { get; set; }
        public virtual Warehouses Warehouse { get; set; }
    }
}
