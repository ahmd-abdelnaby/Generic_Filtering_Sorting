using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace Generic_Filtering_Sorting.Models
{
    public partial class Aggregation
    {
        public Aggregation()
        {
            AggregationDetails = new HashSet<AggregationDetails>();
            InverseChild = new HashSet<Aggregation>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public int? ChildId { get; set; }
        public DateTime Created { get; set; }
        public DateTime Modified { get; set; }
        public bool? IsDeleted { get; set; }

        public virtual Aggregation Child { get; set; }
        public virtual ICollection<AggregationDetails> AggregationDetails { get; set; }
        public virtual ICollection<Aggregation> InverseChild { get; set; }
    }
}
