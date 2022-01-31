using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace Generic_Filtering_Sorting.Models
{
    public partial class Products
    {
        public Products()
        {
            AggregationDetails = new HashSet<AggregationDetails>();
            BillDetails = new HashSet<BillDetails>();
            CustodyAttachmentDetail = new HashSet<CustodyAttachmentDetail>();
            CustodyOrderDetails = new HashSet<CustodyOrderDetails>();
            ShippingOrderDetails = new HashSet<ShippingOrderDetails>();
            StockReports = new HashSet<StockReports>();
            SupplyOrderDetails = new HashSet<SupplyOrderDetails>();
            WareHouseProducts = new HashSet<WareHouseProducts>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public double? Price { get; set; }
        public int ItemCount { get; set; }
        public string BarCode { get; set; }
        public int UnitId { get; set; }
        public DateTime Created { get; set; }
        public DateTime Modified { get; set; }
        public int CategoryId { get; set; }
        public double Insurance { get; set; }
        public double DistributionFees { get; set; }
        public bool? IsDeleted { get; set; }
        public double ProductionCostPrice { get; set; }
        public double ValueAddedTax { get; set; }
        public string ProductCode { get; set; }
        public double DistributionVat { get; set; }
        public double ConsumerPrice { get; set; }
        public short? SortSequence { get; set; }

        public virtual Categories Category { get; set; }
        public virtual Units Unit { get; set; }
        public virtual ICollection<AggregationDetails> AggregationDetails { get; set; }
        public virtual ICollection<BillDetails> BillDetails { get; set; }
        public virtual ICollection<CustodyAttachmentDetail> CustodyAttachmentDetail { get; set; }
        public virtual ICollection<CustodyOrderDetails> CustodyOrderDetails { get; set; }
        public virtual ICollection<ShippingOrderDetails> ShippingOrderDetails { get; set; }
        public virtual ICollection<StockReports> StockReports { get; set; }
        public virtual ICollection<SupplyOrderDetails> SupplyOrderDetails { get; set; }
        public virtual ICollection<WareHouseProducts> WareHouseProducts { get; set; }
    }
}
