using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace Generic_Filtering_Sorting.Models
{
    public partial class Warehouses
    {
        public Warehouses()
        {
            AspNetUsers = new HashSet<AspNetUsers>();
            DailyReports = new HashSet<DailyReports>();
            InverseLinkedToWarehouse = new HashSet<Warehouses>();
            JournalReports = new HashSet<JournalReports>();
            Merchants = new HashSet<Merchants>();
            ShippingOrder = new HashSet<ShippingOrder>();
            StockReports = new HashSet<StockReports>();
            SupplyOrdersFrom = new HashSet<SupplyOrders>();
            SupplyOrdersTo = new HashSet<SupplyOrders>();
            Trips = new HashSet<Trips>();
            WareHouseProducts = new HashSet<WareHouseProducts>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string Phone { get; set; }
        public int? AreaId { get; set; }
        public DateTime Created { get; set; }
        public DateTime Modified { get; set; }
        public bool? IsDeleted { get; set; }
        public int WarehouseTypeId { get; set; }
        public int? LinkedToWarehouseId { get; set; }

        public virtual Areas Area { get; set; }
        public virtual Warehouses LinkedToWarehouse { get; set; }
        public virtual WarehouseTypes WarehouseType { get; set; }
        public virtual ICollection<AspNetUsers> AspNetUsers { get; set; }
        public virtual ICollection<DailyReports> DailyReports { get; set; }
        public virtual ICollection<Warehouses> InverseLinkedToWarehouse { get; set; }
        public virtual ICollection<JournalReports> JournalReports { get; set; }
        public virtual ICollection<Merchants> Merchants { get; set; }
        public virtual ICollection<ShippingOrder> ShippingOrder { get; set; }
        public virtual ICollection<StockReports> StockReports { get; set; }
        public virtual ICollection<SupplyOrders> SupplyOrdersFrom { get; set; }
        public virtual ICollection<SupplyOrders> SupplyOrdersTo { get; set; }
        public virtual ICollection<Trips> Trips { get; set; }
        public virtual ICollection<WareHouseProducts> WareHouseProducts { get; set; }
    }
}
