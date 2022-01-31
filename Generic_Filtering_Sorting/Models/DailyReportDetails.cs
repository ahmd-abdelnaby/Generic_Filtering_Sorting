using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace Generic_Filtering_Sorting.Models
{
    public partial class DailyReportDetails
    {
        public int Id { get; set; }
        public double Price { get; set; }
        public int CategoryId { get; set; }
        public int DailyReportId { get; set; }
        public DateTime Created { get; set; }
        public DateTime Modified { get; set; }
        public bool? IsDeleted { get; set; }

        public virtual Categories Category { get; set; }
        public virtual DailyReports DailyReport { get; set; }
    }
}
