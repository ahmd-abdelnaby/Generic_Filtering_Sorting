using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace Generic_Filtering_Sorting.Models
{
    public partial class WareHouseProducts
    {
        public int Id { get; set; }
        public int? Quantity { get; set; }
        public int WarehouseId { get; set; }
        public int? ProductId { get; set; }
        public DateTime Created { get; set; }
        public DateTime Modified { get; set; }
        public int? AssignedQty { get; set; }
        public bool? IsDeleted { get; set; }

        public virtual Products Product { get; set; }
        public virtual Warehouses Warehouse { get; set; }
    }
}
