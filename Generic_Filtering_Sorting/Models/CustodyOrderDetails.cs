using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace Generic_Filtering_Sorting.Models
{
    public partial class CustodyOrderDetails
    {
        public int Id { get; set; }
        public int OriginalQty { get; set; }
        public double? TotalOriginalQtyPrice { get; set; }
        public int ActualQty { get; set; }
        public double? TotalActualQtyPrice { get; set; }
        public int SoldQty { get; set; }
        public double? TotalSoldQtyPrice { get; set; }
        public double? UnitPrice { get; set; }
        public int? ProductId { get; set; }
        public int CustodyOrderId { get; set; }
        public DateTime Created { get; set; }
        public DateTime Modified { get; set; }
        public bool? IsDeleted { get; set; }

        public virtual CustodyOrder CustodyOrder { get; set; }
        public virtual Products Product { get; set; }
    }
}
