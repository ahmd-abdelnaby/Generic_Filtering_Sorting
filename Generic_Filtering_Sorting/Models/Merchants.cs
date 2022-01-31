using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace Generic_Filtering_Sorting.Models
{
    public partial class Merchants
    {
        public Merchants()
        {
            Bills = new HashSet<Bills>();
            CustodyOrderMerchants = new HashSet<CustodyOrderMerchants>();
            MerchantTokens = new HashSet<MerchantTokens>();
            MerchantZemma = new HashSet<MerchantZemma>();
            Otpstores = new HashSet<Otpstores>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string Telephone { get; set; }
        public int AreaId { get; set; }
        public int MerchantTypeId { get; set; }
        public DateTime Created { get; set; }
        public DateTime Modified { get; set; }
        public bool? IsDeleted { get; set; }
        public string Code { get; set; }
        public string NationalId { get; set; }
        public int? WarehouseId { get; set; }
        public int? MerchantsInfoId { get; set; }

        public virtual Areas Area { get; set; }
        public virtual MerchantTypes MerchantType { get; set; }
        public virtual ContractorInfo MerchantsInfo { get; set; }
        public virtual Warehouses Warehouse { get; set; }
        public virtual ICollection<Bills> Bills { get; set; }
        public virtual ICollection<CustodyOrderMerchants> CustodyOrderMerchants { get; set; }
        public virtual ICollection<MerchantTokens> MerchantTokens { get; set; }
        public virtual ICollection<MerchantZemma> MerchantZemma { get; set; }
        public virtual ICollection<Otpstores> Otpstores { get; set; }
    }
}
