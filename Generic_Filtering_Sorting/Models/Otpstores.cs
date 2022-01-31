using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace Generic_Filtering_Sorting.Models
{
    public partial class Otpstores
    {
        public int Id { get; set; }
        public string OtpKey { get; set; }
        public DateTime OtpGeneratedAt { get; set; }
        public string OtpTargetPhone { get; set; }
        public DateTime Created { get; set; }
        public DateTime Modified { get; set; }
        public bool IsDeleted { get; set; }
        public int MerchantId { get; set; }

        public virtual Merchants Merchant { get; set; }
    }
}
