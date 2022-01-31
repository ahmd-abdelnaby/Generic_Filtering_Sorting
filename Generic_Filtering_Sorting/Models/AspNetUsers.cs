using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace Generic_Filtering_Sorting.Models
{
    public partial class AspNetUsers
    {
        public AspNetUsers()
        {
            AspNetUserClaims = new HashSet<AspNetUserClaims>();
            AspNetUserLogins = new HashSet<AspNetUserLogins>();
            AspNetUserRoles = new HashSet<AspNetUserRoles>();
            AspNetUserTokens = new HashSet<AspNetUserTokens>();
            Bills = new HashSet<Bills>();
            ContractorInfo = new HashSet<ContractorInfo>();
            ContractorMoneyTracking = new HashSet<ContractorMoneyTracking>();
            ContractorTokens = new HashSet<ContractorTokens>();
            CustodyAttachment = new HashSet<CustodyAttachment>();
            CustodyOrderAssignedTo = new HashSet<CustodyOrder>();
            CustodyOrderCreatedBy = new HashSet<CustodyOrder>();
            DailyReports = new HashSet<DailyReports>();
            Notifications = new HashSet<Notifications>();
            RefreshToken = new HashSet<RefreshToken>();
            ShippingOrder = new HashSet<ShippingOrder>();
            SupplyOrderPayments = new HashSet<SupplyOrderPayments>();
            SupplyOrdersAcceptedBy = new HashSet<SupplyOrders>();
            SupplyOrdersAssignedTo = new HashSet<SupplyOrders>();
            SupplyOrdersCreatedBy = new HashSet<SupplyOrders>();
            SupplyOrdersReceivedBy = new HashSet<SupplyOrders>();
            TripsAcceptedBy = new HashSet<Trips>();
            TripsAssignedTo = new HashSet<Trips>();
            TripsCreatedBy = new HashSet<Trips>();
            Zemma = new HashSet<Zemma>();
        }

        public string Id { get; set; }
        public string Nid { get; set; }
        public string Address { get; set; }
        public int? WarehouseId { get; set; }
        public string UserName { get; set; }
        public string NormalizedUserName { get; set; }
        public string Email { get; set; }
        public string NormalizedEmail { get; set; }
        public bool EmailConfirmed { get; set; }
        public string PasswordHash { get; set; }
        public string SecurityStamp { get; set; }
        public string ConcurrencyStamp { get; set; }
        public string PhoneNumber { get; set; }
        public bool PhoneNumberConfirmed { get; set; }
        public bool TwoFactorEnabled { get; set; }
        public DateTimeOffset? LockoutEnd { get; set; }
        public bool LockoutEnabled { get; set; }
        public int AccessFailedCount { get; set; }
        public string DisplayName { get; set; }
        public int? AreaId { get; set; }
        public int CommercialRecord { get; set; }
        public int TaxRecord { get; set; }

        public virtual Areas Area { get; set; }
        public virtual Warehouses Warehouse { get; set; }
        public virtual ICollection<AspNetUserClaims> AspNetUserClaims { get; set; }
        public virtual ICollection<AspNetUserLogins> AspNetUserLogins { get; set; }
        public virtual ICollection<AspNetUserRoles> AspNetUserRoles { get; set; }
        public virtual ICollection<AspNetUserTokens> AspNetUserTokens { get; set; }
        public virtual ICollection<Bills> Bills { get; set; }
        public virtual ICollection<ContractorInfo> ContractorInfo { get; set; }
        public virtual ICollection<ContractorMoneyTracking> ContractorMoneyTracking { get; set; }
        public virtual ICollection<ContractorTokens> ContractorTokens { get; set; }
        public virtual ICollection<CustodyAttachment> CustodyAttachment { get; set; }
        public virtual ICollection<CustodyOrder> CustodyOrderAssignedTo { get; set; }
        public virtual ICollection<CustodyOrder> CustodyOrderCreatedBy { get; set; }
        public virtual ICollection<DailyReports> DailyReports { get; set; }
        public virtual ICollection<Notifications> Notifications { get; set; }
        public virtual ICollection<RefreshToken> RefreshToken { get; set; }
        public virtual ICollection<ShippingOrder> ShippingOrder { get; set; }
        public virtual ICollection<SupplyOrderPayments> SupplyOrderPayments { get; set; }
        public virtual ICollection<SupplyOrders> SupplyOrdersAcceptedBy { get; set; }
        public virtual ICollection<SupplyOrders> SupplyOrdersAssignedTo { get; set; }
        public virtual ICollection<SupplyOrders> SupplyOrdersCreatedBy { get; set; }
        public virtual ICollection<SupplyOrders> SupplyOrdersReceivedBy { get; set; }
        public virtual ICollection<Trips> TripsAcceptedBy { get; set; }
        public virtual ICollection<Trips> TripsAssignedTo { get; set; }
        public virtual ICollection<Trips> TripsCreatedBy { get; set; }
        public virtual ICollection<Zemma> Zemma { get; set; }
    }
}
