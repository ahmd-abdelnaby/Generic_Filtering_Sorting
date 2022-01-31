using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace Generic_Filtering_Sorting.Models
{
    public partial class Areas
    {
        public Areas()
        {
            AspNetUsers = new HashSet<AspNetUsers>();
            Merchants = new HashSet<Merchants>();
            Warehouses = new HashSet<Warehouses>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime Created { get; set; }
        public DateTime Modified { get; set; }
        public bool? IsDeleted { get; set; }
        public int GovernorateId { get; set; }

        public virtual Governorates Governorate { get; set; }
        public virtual ICollection<AspNetUsers> AspNetUsers { get; set; }
        public virtual ICollection<Merchants> Merchants { get; set; }
        public virtual ICollection<Warehouses> Warehouses { get; set; }
    }
}
