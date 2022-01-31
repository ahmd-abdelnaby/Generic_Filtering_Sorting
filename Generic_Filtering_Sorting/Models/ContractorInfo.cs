using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace Generic_Filtering_Sorting.Models
{
    public partial class ContractorInfo
    {
        public ContractorInfo()
        {
            Merchants = new HashSet<Merchants>();
        }

        public int Id { get; set; }
        public string ContractorId { get; set; }
        public string UniqueTaxId { get; set; }
        public string TaxCardNumber { get; set; }
        public DateTime Created { get; set; }
        public DateTime Modified { get; set; }
        public bool IsDeleted { get; set; }

        public virtual AspNetUsers Contractor { get; set; }
        public virtual ICollection<Merchants> Merchants { get; set; }
    }
}
