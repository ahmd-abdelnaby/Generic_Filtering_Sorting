using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace Generic_Filtering_Sorting.Models
{
    public partial class SCMQualityContext : DbContext
    {
        public SCMQualityContext()
        {
        }

        public SCMQualityContext(DbContextOptions<SCMQualityContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Aggregation> Aggregation { get; set; }
        public virtual DbSet<AggregationDetails> AggregationDetails { get; set; }
        public virtual DbSet<Areas> Areas { get; set; }
        public virtual DbSet<AspNetRoleClaims> AspNetRoleClaims { get; set; }
        public virtual DbSet<AspNetRoles> AspNetRoles { get; set; }
        public virtual DbSet<AspNetUserClaims> AspNetUserClaims { get; set; }
        public virtual DbSet<AspNetUserLogins> AspNetUserLogins { get; set; }
        public virtual DbSet<AspNetUserRoles> AspNetUserRoles { get; set; }
        public virtual DbSet<AspNetUserTokens> AspNetUserTokens { get; set; }
        public virtual DbSet<AspNetUsers> AspNetUsers { get; set; }
        public virtual DbSet<Bank> Bank { get; set; }
        public virtual DbSet<BankDeposit> BankDeposit { get; set; }
        public virtual DbSet<BillDetails> BillDetails { get; set; }
        public virtual DbSet<BillPayment> BillPayment { get; set; }
        public virtual DbSet<Bills> Bills { get; set; }
        public virtual DbSet<Categories> Categories { get; set; }
        public virtual DbSet<ContractorInfo> ContractorInfo { get; set; }
        public virtual DbSet<ContractorMoneyTracking> ContractorMoneyTracking { get; set; }
        public virtual DbSet<ContractorTokens> ContractorTokens { get; set; }
        public virtual DbSet<CustodyAttachment> CustodyAttachment { get; set; }
        public virtual DbSet<CustodyAttachmentDetail> CustodyAttachmentDetail { get; set; }
        public virtual DbSet<CustodyOrder> CustodyOrder { get; set; }
        public virtual DbSet<CustodyOrderDetails> CustodyOrderDetails { get; set; }
        public virtual DbSet<CustodyOrderMerchants> CustodyOrderMerchants { get; set; }
        public virtual DbSet<CustodyOrderStates> CustodyOrderStates { get; set; }
        public virtual DbSet<DailyReportDetails> DailyReportDetails { get; set; }
        public virtual DbSet<DailyReports> DailyReports { get; set; }
        public virtual DbSet<Governorates> Governorates { get; set; }
        public virtual DbSet<JournalReports> JournalReports { get; set; }
        public virtual DbSet<MerchantTokens> MerchantTokens { get; set; }
        public virtual DbSet<MerchantTypes> MerchantTypes { get; set; }
        public virtual DbSet<MerchantZemma> MerchantZemma { get; set; }
        public virtual DbSet<Merchants> Merchants { get; set; }
        public virtual DbSet<NotificationTypes> NotificationTypes { get; set; }
        public virtual DbSet<Notifications> Notifications { get; set; }
        public virtual DbSet<Otpstores> Otpstores { get; set; }
        public virtual DbSet<PaymentMethods> PaymentMethods { get; set; }
        public virtual DbSet<Products> Products { get; set; }
        public virtual DbSet<RefreshToken> RefreshToken { get; set; }
        public virtual DbSet<ShippingOrder> ShippingOrder { get; set; }
        public virtual DbSet<ShippingOrderDetails> ShippingOrderDetails { get; set; }
        public virtual DbSet<ShippingOrderPaymentDetails> ShippingOrderPaymentDetails { get; set; }
        public virtual DbSet<StockReports> StockReports { get; set; }
        public virtual DbSet<SupplyOrderDetails> SupplyOrderDetails { get; set; }
        public virtual DbSet<SupplyOrderPaymentDetails> SupplyOrderPaymentDetails { get; set; }
        public virtual DbSet<SupplyOrderPayments> SupplyOrderPayments { get; set; }
        public virtual DbSet<SupplyOrderStates> SupplyOrderStates { get; set; }
        public virtual DbSet<SupplyOrders> SupplyOrders { get; set; }
        public virtual DbSet<TripState> TripState { get; set; }
        public virtual DbSet<Trips> Trips { get; set; }
        public virtual DbSet<Units> Units { get; set; }
        public virtual DbSet<WareHouseProducts> WareHouseProducts { get; set; }
        public virtual DbSet<WarehouseTypes> WarehouseTypes { get; set; }
        public virtual DbSet<Warehouses> Warehouses { get; set; }
        public virtual DbSet<Zemma> Zemma { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("Data Source=197.168.1.110;Initial Catalog=SCMQuality;User ID=scm;Password=SCM@2021;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Aggregation>(entity =>
            {
                entity.HasIndex(e => e.ChildId);

                entity.Property(e => e.Created).HasDefaultValueSql("(getdate())");

                entity.Property(e => e.IsDeleted)
                    .IsRequired()
                    .HasDefaultValueSql("(CONVERT([bit],(0)))");

                entity.Property(e => e.Modified).HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Name).HasMaxLength(50);

                entity.HasOne(d => d.Child)
                    .WithMany(p => p.InverseChild)
                    .HasForeignKey(d => d.ChildId);
            });

            modelBuilder.Entity<AggregationDetails>(entity =>
            {
                entity.HasIndex(e => e.AggregationId);

                entity.HasIndex(e => e.ProductId);

                entity.Property(e => e.Created).HasDefaultValueSql("(getdate())");

                entity.Property(e => e.IsDeleted)
                    .IsRequired()
                    .HasDefaultValueSql("(CONVERT([bit],(0)))");

                entity.Property(e => e.Modified).HasDefaultValueSql("(getdate())");

                entity.HasOne(d => d.Aggregation)
                    .WithMany(p => p.AggregationDetails)
                    .HasForeignKey(d => d.AggregationId);

                entity.HasOne(d => d.Product)
                    .WithMany(p => p.AggregationDetails)
                    .HasForeignKey(d => d.ProductId);
            });

            modelBuilder.Entity<Areas>(entity =>
            {
                entity.HasIndex(e => e.GovernorateId);

                entity.Property(e => e.Created).HasDefaultValueSql("(getdate())");

                entity.Property(e => e.IsDeleted)
                    .IsRequired()
                    .HasDefaultValueSql("(CONVERT([bit],(0)))");

                entity.Property(e => e.Modified).HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Name).HasMaxLength(50);

                entity.HasOne(d => d.Governorate)
                    .WithMany(p => p.Areas)
                    .HasForeignKey(d => d.GovernorateId);
            });

            modelBuilder.Entity<AspNetRoleClaims>(entity =>
            {
                entity.HasIndex(e => e.RoleId);

                entity.Property(e => e.RoleId).IsRequired();

                entity.HasOne(d => d.Role)
                    .WithMany(p => p.AspNetRoleClaims)
                    .HasForeignKey(d => d.RoleId);
            });

            modelBuilder.Entity<AspNetRoles>(entity =>
            {
                entity.HasIndex(e => e.NormalizedName)
                    .HasName("RoleNameIndex")
                    .IsUnique()
                    .HasFilter("([NormalizedName] IS NOT NULL)");

                entity.Property(e => e.Name).HasMaxLength(256);

                entity.Property(e => e.NormalizedName).HasMaxLength(256);
            });

            modelBuilder.Entity<AspNetUserClaims>(entity =>
            {
                entity.HasIndex(e => e.UserId);

                entity.Property(e => e.UserId).IsRequired();

                entity.HasOne(d => d.User)
                    .WithMany(p => p.AspNetUserClaims)
                    .HasForeignKey(d => d.UserId);
            });

            modelBuilder.Entity<AspNetUserLogins>(entity =>
            {
                entity.HasKey(e => new { e.LoginProvider, e.ProviderKey });

                entity.HasIndex(e => e.UserId);

                entity.Property(e => e.UserId).IsRequired();

                entity.HasOne(d => d.User)
                    .WithMany(p => p.AspNetUserLogins)
                    .HasForeignKey(d => d.UserId);
            });

            modelBuilder.Entity<AspNetUserRoles>(entity =>
            {
                entity.HasKey(e => new { e.UserId, e.RoleId });

                entity.HasIndex(e => e.RoleId);

                entity.Property(e => e.Discriminator).IsRequired();

                entity.HasOne(d => d.Role)
                    .WithMany(p => p.AspNetUserRoles)
                    .HasForeignKey(d => d.RoleId);

                entity.HasOne(d => d.User)
                    .WithMany(p => p.AspNetUserRoles)
                    .HasForeignKey(d => d.UserId);
            });

            modelBuilder.Entity<AspNetUserTokens>(entity =>
            {
                entity.HasKey(e => new { e.UserId, e.LoginProvider, e.Name });

                entity.HasOne(d => d.User)
                    .WithMany(p => p.AspNetUserTokens)
                    .HasForeignKey(d => d.UserId);
            });

            modelBuilder.Entity<AspNetUsers>(entity =>
            {
                entity.HasIndex(e => e.AreaId);

                entity.HasIndex(e => e.NormalizedEmail)
                    .HasName("EmailIndex");

                entity.HasIndex(e => e.NormalizedUserName)
                    .HasName("UserNameIndex")
                    .IsUnique()
                    .HasFilter("([NormalizedUserName] IS NOT NULL)");

                entity.HasIndex(e => e.WarehouseId);

                entity.Property(e => e.Email).HasMaxLength(256);

                entity.Property(e => e.Nid).HasMaxLength(14);

                entity.Property(e => e.NormalizedEmail).HasMaxLength(256);

                entity.Property(e => e.NormalizedUserName).HasMaxLength(256);

                entity.Property(e => e.UserName).HasMaxLength(256);

                entity.HasOne(d => d.Area)
                    .WithMany(p => p.AspNetUsers)
                    .HasForeignKey(d => d.AreaId);

                entity.HasOne(d => d.Warehouse)
                    .WithMany(p => p.AspNetUsers)
                    .HasForeignKey(d => d.WarehouseId);
            });

            modelBuilder.Entity<BankDeposit>(entity =>
            {
                entity.Property(e => e.DepositNumber).HasMaxLength(50);
            });

            modelBuilder.Entity<BillDetails>(entity =>
            {
                entity.HasIndex(e => e.BillId);

                entity.HasIndex(e => e.ProductId);

                entity.Property(e => e.Created).HasDefaultValueSql("(getdate())");

                entity.Property(e => e.IsDeleted)
                    .IsRequired()
                    .HasDefaultValueSql("(CONVERT([bit],(0)))");

                entity.Property(e => e.Modified).HasDefaultValueSql("(getdate())");

                entity.HasOne(d => d.Bill)
                    .WithMany(p => p.BillDetails)
                    .HasForeignKey(d => d.BillId)
                    .OnDelete(DeleteBehavior.Cascade);

                entity.HasOne(d => d.Product)
                    .WithMany(p => p.BillDetails)
                    .HasForeignKey(d => d.ProductId);
            });

            modelBuilder.Entity<BillPayment>(entity =>
            {
                entity.HasIndex(e => e.BankDepositId);

                entity.HasIndex(e => e.BillId)
                    .IsUnique();

                entity.Property(e => e.CarHelp).HasComment("مساعدة السياره");

                entity.Property(e => e.Created).HasDefaultValueSql("(getdate())");

                entity.Property(e => e.FinancialDisclosure).HasComment("ذمم ماليه");

                entity.Property(e => e.IsDeleted)
                    .IsRequired()
                    .HasDefaultValueSql("(CONVERT([bit],(0)))");

                entity.Property(e => e.Modified).HasDefaultValueSql("(getdate())");

                entity.Property(e => e.MonthcommercialDiscount).HasComment("خصم تجارى عن شهر");

                entity.Property(e => e.OtherWarehousesCash).HasComment("نقديه مسدده بمخازن اخرى");

                entity.Property(e => e.PromotionalDiscount).HasComment("خصم ترويجى");

                entity.Property(e => e.WarehouseCash).HasComment("نقدا بخزينة المخزن");

                entity.HasOne(d => d.BankDeposit)
                    .WithMany(p => p.BillPayment)
                    .HasForeignKey(d => d.BankDepositId)
                    .OnDelete(DeleteBehavior.ClientSetNull);

                entity.HasOne(d => d.Bill)
                    .WithOne(p => p.BillPayment)
                    .HasForeignKey<BillPayment>(d => d.BillId);
            });

            modelBuilder.Entity<Bills>(entity =>
            {
                entity.HasIndex(e => e.BillNumber)
                    .IsUnique()
                    .HasFilter("([BillNumber] IS NOT NULL)");

                entity.HasIndex(e => e.CreatedBy);

                entity.HasIndex(e => e.MerchantId);

                entity.HasIndex(e => e.PaymentMethodId);

                entity.Property(e => e.BillNumber)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Created).HasDefaultValueSql("(getdate())");

                entity.Property(e => e.IsDeleted)
                    .IsRequired()
                    .HasDefaultValueSql("(CONVERT([bit],(0)))");

                entity.Property(e => e.Modified).HasDefaultValueSql("(getdate())");

                entity.Property(e => e.PaymentStatus)
                    .IsRequired()
                    .HasDefaultValueSql("(CONVERT([bit],(0)))");

                entity.HasOne(d => d.CreatedByNavigation)
                    .WithMany(p => p.Bills)
                    .HasForeignKey(d => d.CreatedBy);

                entity.HasOne(d => d.Merchant)
                    .WithMany(p => p.Bills)
                    .HasForeignKey(d => d.MerchantId);

                entity.HasOne(d => d.PaymentMethod)
                    .WithMany(p => p.Bills)
                    .HasForeignKey(d => d.PaymentMethodId);
            });

            modelBuilder.Entity<Categories>(entity =>
            {
                entity.HasIndex(e => e.DisplayOrder)
                    .IsUnique()
                    .HasFilter("([DisplayOrder] IS NOT NULL)");

                entity.Property(e => e.Created).HasDefaultValueSql("(getdate())");

                entity.Property(e => e.IsDeleted)
                    .IsRequired()
                    .HasDefaultValueSql("(CONVERT([bit],(0)))");

                entity.Property(e => e.Modified).HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Name).HasMaxLength(50);
            });

            modelBuilder.Entity<ContractorInfo>(entity =>
            {
                entity.HasIndex(e => e.ContractorId);

                entity.Property(e => e.TaxCardNumber)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.UniqueTaxId)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.HasOne(d => d.Contractor)
                    .WithMany(p => p.ContractorInfo)
                    .HasForeignKey(d => d.ContractorId);
            });

            modelBuilder.Entity<ContractorMoneyTracking>(entity =>
            {
                entity.HasIndex(e => e.UserId);

                entity.HasOne(d => d.User)
                    .WithMany(p => p.ContractorMoneyTracking)
                    .HasForeignKey(d => d.UserId);
            });

            modelBuilder.Entity<ContractorTokens>(entity =>
            {
                entity.HasIndex(e => e.UserId);

                entity.Property(e => e.Created).HasDefaultValueSql("(getdate())");

                entity.Property(e => e.IsDeleted)
                    .IsRequired()
                    .HasDefaultValueSql("(CONVERT([bit],(0)))");

                entity.Property(e => e.Modified).HasDefaultValueSql("(getdate())");

                entity.Property(e => e.MpgsApikey).HasColumnName("Mpgs_apikey");

                entity.Property(e => e.MpgsMid).HasColumnName("Mpgs_mid");

                entity.Property(e => e.MpgsTest).HasColumnName("Mpgs_test");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.ContractorTokens)
                    .HasForeignKey(d => d.UserId);
            });

            modelBuilder.Entity<CustodyAttachment>(entity =>
            {
                entity.HasIndex(e => e.CreatedById);

                entity.HasIndex(e => e.CustodyOrderId);

                entity.HasOne(d => d.CreatedBy)
                    .WithMany(p => p.CustodyAttachment)
                    .HasForeignKey(d => d.CreatedById);

                entity.HasOne(d => d.CustodyOrder)
                    .WithMany(p => p.CustodyAttachment)
                    .HasForeignKey(d => d.CustodyOrderId);
            });

            modelBuilder.Entity<CustodyAttachmentDetail>(entity =>
            {
                entity.HasIndex(e => e.CustodyAttachmentId);

                entity.HasIndex(e => e.ProductId);

                entity.HasOne(d => d.CustodyAttachment)
                    .WithMany(p => p.CustodyAttachmentDetail)
                    .HasForeignKey(d => d.CustodyAttachmentId);

                entity.HasOne(d => d.Product)
                    .WithMany(p => p.CustodyAttachmentDetail)
                    .HasForeignKey(d => d.ProductId);
            });

            modelBuilder.Entity<CustodyOrder>(entity =>
            {
                entity.HasIndex(e => e.AssignedToId);

                entity.HasIndex(e => e.CreatedById);

                entity.HasIndex(e => e.OrderNumber)
                    .IsUnique()
                    .HasFilter("([OrderNumber] IS NOT NULL)");

                entity.HasIndex(e => e.StateId);

                entity.Property(e => e.Created).HasDefaultValueSql("(getdate())");

                entity.Property(e => e.IsDeleted)
                    .IsRequired()
                    .HasDefaultValueSql("(CONVERT([bit],(0)))");

                entity.Property(e => e.Modified).HasDefaultValueSql("(getdate())");

                entity.Property(e => e.OrderNumber)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.HasOne(d => d.AssignedTo)
                    .WithMany(p => p.CustodyOrderAssignedTo)
                    .HasForeignKey(d => d.AssignedToId);

                entity.HasOne(d => d.CreatedBy)
                    .WithMany(p => p.CustodyOrderCreatedBy)
                    .HasForeignKey(d => d.CreatedById);

                entity.HasOne(d => d.State)
                    .WithMany(p => p.CustodyOrder)
                    .HasForeignKey(d => d.StateId);
            });

            modelBuilder.Entity<CustodyOrderDetails>(entity =>
            {
                entity.HasIndex(e => e.CustodyOrderId);

                entity.HasIndex(e => e.ProductId);

                entity.Property(e => e.Created).HasDefaultValueSql("(getdate())");

                entity.Property(e => e.IsDeleted)
                    .IsRequired()
                    .HasDefaultValueSql("(CONVERT([bit],(0)))");

                entity.Property(e => e.Modified).HasDefaultValueSql("(getdate())");

                entity.HasOne(d => d.CustodyOrder)
                    .WithMany(p => p.CustodyOrderDetails)
                    .HasForeignKey(d => d.CustodyOrderId);

                entity.HasOne(d => d.Product)
                    .WithMany(p => p.CustodyOrderDetails)
                    .HasForeignKey(d => d.ProductId);
            });

            modelBuilder.Entity<CustodyOrderMerchants>(entity =>
            {
                entity.HasIndex(e => e.CustodyOrderId);

                entity.HasIndex(e => e.MerchantId);

                entity.Property(e => e.IsDeleted)
                    .IsRequired()
                    .HasDefaultValueSql("(CONVERT([bit],(0)))");

                entity.HasOne(d => d.CustodyOrder)
                    .WithMany(p => p.CustodyOrderMerchants)
                    .HasForeignKey(d => d.CustodyOrderId);

                entity.HasOne(d => d.Merchant)
                    .WithMany(p => p.CustodyOrderMerchants)
                    .HasForeignKey(d => d.MerchantId);
            });

            modelBuilder.Entity<CustodyOrderStates>(entity =>
            {
                entity.Property(e => e.Created).HasDefaultValueSql("(getdate())");

                entity.Property(e => e.IsDeleted)
                    .IsRequired()
                    .HasDefaultValueSql("(CONVERT([bit],(0)))");

                entity.Property(e => e.Modified).HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Name).HasMaxLength(50);
            });

            modelBuilder.Entity<DailyReportDetails>(entity =>
            {
                entity.HasIndex(e => e.CategoryId);

                entity.HasIndex(e => e.DailyReportId);

                entity.Property(e => e.Created).HasDefaultValueSql("(getdate())");

                entity.Property(e => e.IsDeleted)
                    .IsRequired()
                    .HasDefaultValueSql("(CONVERT([bit],(0)))");

                entity.Property(e => e.Modified).HasDefaultValueSql("(getdate())");

                entity.HasOne(d => d.Category)
                    .WithMany(p => p.DailyReportDetails)
                    .HasForeignKey(d => d.CategoryId);

                entity.HasOne(d => d.DailyReport)
                    .WithMany(p => p.DailyReportDetails)
                    .HasForeignKey(d => d.DailyReportId);
            });

            modelBuilder.Entity<DailyReports>(entity =>
            {
                entity.HasIndex(e => e.UserId);

                entity.HasIndex(e => e.WarehouseId);

                entity.Property(e => e.Created).HasDefaultValueSql("(getdate())");

                entity.Property(e => e.IsDeleted)
                    .IsRequired()
                    .HasDefaultValueSql("(CONVERT([bit],(0)))");

                entity.Property(e => e.Modified).HasDefaultValueSql("(getdate())");

                entity.Property(e => e.UserId).IsRequired();

                entity.HasOne(d => d.User)
                    .WithMany(p => p.DailyReports)
                    .HasForeignKey(d => d.UserId);

                entity.HasOne(d => d.Warehouse)
                    .WithMany(p => p.DailyReports)
                    .HasForeignKey(d => d.WarehouseId);
            });

            modelBuilder.Entity<Governorates>(entity =>
            {
                entity.Property(e => e.Created).HasDefaultValueSql("(getdate())");

                entity.Property(e => e.IsDeleted)
                    .IsRequired()
                    .HasDefaultValueSql("(CONVERT([bit],(0)))");

                entity.Property(e => e.Modified).HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Name).HasMaxLength(50);
            });

            modelBuilder.Entity<JournalReports>(entity =>
            {
                entity.Property(e => e.CompanyIsBlue)
                    .IsRequired()
                    .HasDefaultValueSql("(CONVERT([bit],(0)))");

                entity.Property(e => e.Created).HasDefaultValueSql("(getdate())");

                entity.Property(e => e.DebtsIsBlue)
                    .IsRequired()
                    .HasDefaultValueSql("(CONVERT([bit],(0)))");

                entity.Property(e => e.GoodsIsBlue)
                    .IsRequired()
                    .HasDefaultValueSql("(CONVERT([bit],(0)))");

                entity.Property(e => e.IsDeleted)
                    .IsRequired()
                    .HasDefaultValueSql("(CONVERT([bit],(0)))");

                entity.Property(e => e.Modified).HasDefaultValueSql("(getdate())");

                entity.Property(e => e.OtherDebtsIsBlue)
                    .IsRequired()
                    .HasDefaultValueSql("(CONVERT([bit],(0)))");

                entity.Property(e => e.OtherWarehouseIsBlue)
                    .IsRequired()
                    .HasDefaultValueSql("(CONVERT([bit],(0)))");

                entity.Property(e => e.Statement).HasMaxLength(255);

                entity.Property(e => e.SubWarehousesIsBlue)
                    .IsRequired()
                    .HasDefaultValueSql("(CONVERT([bit],(0)))");

                entity.Property(e => e.TreasuryIsBlue)
                    .IsRequired()
                    .HasDefaultValueSql("(CONVERT([bit],(0)))");

                entity.HasOne(d => d.Warehouse)
                    .WithMany(p => p.JournalReports)
                    .HasForeignKey(d => d.WarehouseId);
            });

            modelBuilder.Entity<MerchantTokens>(entity =>
            {
                entity.HasIndex(e => e.MerchantId);

                entity.Property(e => e.Created).HasDefaultValueSql("(getdate())");

                entity.Property(e => e.IsDeleted)
                    .IsRequired()
                    .HasDefaultValueSql("(CONVERT([bit],(0)))");

                entity.Property(e => e.Modified).HasDefaultValueSql("(getdate())");

                entity.HasOne(d => d.Merchant)
                    .WithMany(p => p.MerchantTokens)
                    .HasForeignKey(d => d.MerchantId);
            });

            modelBuilder.Entity<MerchantTypes>(entity =>
            {
                entity.Property(e => e.Created).HasDefaultValueSql("(getdate())");

                entity.Property(e => e.IsDeleted)
                    .IsRequired()
                    .HasDefaultValueSql("(CONVERT([bit],(0)))");

                entity.Property(e => e.Modified).HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Name).HasMaxLength(50);
            });

            modelBuilder.Entity<MerchantZemma>(entity =>
            {
                entity.HasIndex(e => e.MerchantId);

                entity.HasOne(d => d.Merchant)
                    .WithMany(p => p.MerchantZemma)
                    .HasForeignKey(d => d.MerchantId);
            });

            modelBuilder.Entity<Merchants>(entity =>
            {
                entity.HasIndex(e => e.AreaId);

                entity.HasIndex(e => e.MerchantTypeId);

                entity.HasIndex(e => e.MerchantsInfoId);

                entity.HasIndex(e => e.WarehouseId);

                entity.Property(e => e.Address).HasMaxLength(255);

                entity.Property(e => e.Code).HasMaxLength(12);

                entity.Property(e => e.Created).HasDefaultValueSql("(getdate())");

                entity.Property(e => e.IsDeleted)
                    .IsRequired()
                    .HasDefaultValueSql("(CONVERT([bit],(0)))");

                entity.Property(e => e.Modified).HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Name).HasMaxLength(50);

                entity.Property(e => e.NationalId).HasMaxLength(14);

                entity.HasOne(d => d.Area)
                    .WithMany(p => p.Merchants)
                    .HasForeignKey(d => d.AreaId)
                    .OnDelete(DeleteBehavior.ClientSetNull);

                entity.HasOne(d => d.MerchantType)
                    .WithMany(p => p.Merchants)
                    .HasForeignKey(d => d.MerchantTypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull);

                entity.HasOne(d => d.MerchantsInfo)
                    .WithMany(p => p.Merchants)
                    .HasForeignKey(d => d.MerchantsInfoId);

                entity.HasOne(d => d.Warehouse)
                    .WithMany(p => p.Merchants)
                    .HasForeignKey(d => d.WarehouseId);
            });

            modelBuilder.Entity<NotificationTypes>(entity =>
            {
                entity.Property(e => e.Created).HasDefaultValueSql("(getdate())");

                entity.Property(e => e.IsDeleted)
                    .IsRequired()
                    .HasDefaultValueSql("(CONVERT([bit],(0)))");

                entity.Property(e => e.Modified).HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<Notifications>(entity =>
            {
                entity.HasIndex(e => e.NotificationId);

                entity.HasIndex(e => e.UserId);

                entity.Property(e => e.Body).HasMaxLength(100);

                entity.Property(e => e.Created).HasDefaultValueSql("(getdate())");

                entity.Property(e => e.IsDeleted)
                    .IsRequired()
                    .HasDefaultValueSql("(CONVERT([bit],(0)))");

                entity.Property(e => e.IsRead)
                    .IsRequired()
                    .HasDefaultValueSql("(CONVERT([bit],(0)))");

                entity.Property(e => e.Modified).HasDefaultValueSql("(getdate())");

                entity.Property(e => e.OrderNumber).HasMaxLength(50);

                entity.Property(e => e.Title).HasMaxLength(100);

                entity.HasOne(d => d.Notification)
                    .WithMany(p => p.Notifications)
                    .HasForeignKey(d => d.NotificationId);

                entity.HasOne(d => d.User)
                    .WithMany(p => p.Notifications)
                    .HasForeignKey(d => d.UserId);
            });

            modelBuilder.Entity<Otpstores>(entity =>
            {
                entity.ToTable("OTPStores");

                entity.HasIndex(e => e.MerchantId);

                entity.HasOne(d => d.Merchant)
                    .WithMany(p => p.Otpstores)
                    .HasForeignKey(d => d.MerchantId);
            });

            modelBuilder.Entity<PaymentMethods>(entity =>
            {
                entity.Property(e => e.Created).HasDefaultValueSql("(getdate())");

                entity.Property(e => e.IsDeleted)
                    .IsRequired()
                    .HasDefaultValueSql("(CONVERT([bit],(0)))");

                entity.Property(e => e.Modified).HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Name).HasMaxLength(50);
            });

            modelBuilder.Entity<Products>(entity =>
            {
                entity.HasIndex(e => e.CategoryId);

                entity.HasIndex(e => e.UnitId);

                entity.Property(e => e.BarCode).HasMaxLength(16);

                entity.Property(e => e.Created).HasDefaultValueSql("(getdate())");

                entity.Property(e => e.DistributionVat).HasColumnName("DistributionVAT");

                entity.Property(e => e.IsDeleted)
                    .IsRequired()
                    .HasDefaultValueSql("(CONVERT([bit],(0)))");

                entity.Property(e => e.Modified).HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Name).HasMaxLength(50);

                entity.HasOne(d => d.Category)
                    .WithMany(p => p.Products)
                    .HasForeignKey(d => d.CategoryId)
                    .OnDelete(DeleteBehavior.ClientSetNull);

                entity.HasOne(d => d.Unit)
                    .WithMany(p => p.Products)
                    .HasForeignKey(d => d.UnitId)
                    .OnDelete(DeleteBehavior.ClientSetNull);
            });

            modelBuilder.Entity<RefreshToken>(entity =>
            {
                entity.HasIndex(e => e.OwnerId);

                entity.Property(e => e.IsDeleted)
                    .IsRequired()
                    .HasDefaultValueSql("(CONVERT([bit],(0)))");

                entity.HasOne(d => d.Owner)
                    .WithMany(p => p.RefreshToken)
                    .HasForeignKey(d => d.OwnerId);
            });

            modelBuilder.Entity<ShippingOrder>(entity =>
            {
                entity.HasIndex(e => e.CreatedById);

                entity.HasIndex(e => e.OrderNumber)
                    .IsUnique()
                    .HasFilter("([OrderNumber] IS NOT NULL)");

                entity.HasIndex(e => e.ToId);

                entity.Property(e => e.Created).HasDefaultValueSql("(getdate())");

                entity.Property(e => e.IsDeleted)
                    .IsRequired()
                    .HasDefaultValueSql("(CONVERT([bit],(0)))");

                entity.Property(e => e.Modified).HasDefaultValueSql("(getdate())");

                entity.Property(e => e.OrderNumber).HasMaxLength(50);

                entity.HasOne(d => d.CreatedBy)
                    .WithMany(p => p.ShippingOrder)
                    .HasForeignKey(d => d.CreatedById);

                entity.HasOne(d => d.To)
                    .WithMany(p => p.ShippingOrder)
                    .HasForeignKey(d => d.ToId)
                    .OnDelete(DeleteBehavior.ClientSetNull);
            });

            modelBuilder.Entity<ShippingOrderDetails>(entity =>
            {
                entity.HasIndex(e => e.ProductId);

                entity.HasIndex(e => e.ShippingOrderId);

                entity.Property(e => e.Created).HasDefaultValueSql("(getdate())");

                entity.Property(e => e.IsDeleted)
                    .IsRequired()
                    .HasDefaultValueSql("(CONVERT([bit],(0)))");

                entity.Property(e => e.Modified).HasDefaultValueSql("(getdate())");

                entity.HasOne(d => d.Product)
                    .WithMany(p => p.ShippingOrderDetails)
                    .HasForeignKey(d => d.ProductId);

                entity.HasOne(d => d.ShippingOrder)
                    .WithMany(p => p.ShippingOrderDetails)
                    .HasForeignKey(d => d.ShippingOrderId);
            });

            modelBuilder.Entity<ShippingOrderPaymentDetails>(entity =>
            {
                entity.HasIndex(e => e.BankDepositId);

                entity.HasIndex(e => e.ShippingOrderId)
                    .IsUnique();

                entity.HasOne(d => d.BankDeposit)
                    .WithMany(p => p.ShippingOrderPaymentDetails)
                    .HasForeignKey(d => d.BankDepositId);

                entity.HasOne(d => d.ShippingOrder)
                    .WithOne(p => p.ShippingOrderPaymentDetails)
                    .HasForeignKey<ShippingOrderPaymentDetails>(d => d.ShippingOrderId);
            });

            modelBuilder.Entity<StockReports>(entity =>
            {
                entity.HasIndex(e => e.ProductId);

                entity.HasIndex(e => e.WarehouseId);

                entity.Property(e => e.Created).HasDefaultValueSql("(getdate())");

                entity.Property(e => e.IsDeleted)
                    .IsRequired()
                    .HasDefaultValueSql("(CONVERT([bit],(0)))");

                entity.Property(e => e.Modified).HasDefaultValueSql("(getdate())");

                entity.HasOne(d => d.Product)
                    .WithMany(p => p.StockReports)
                    .HasForeignKey(d => d.ProductId);

                entity.HasOne(d => d.Warehouse)
                    .WithMany(p => p.StockReports)
                    .HasForeignKey(d => d.WarehouseId);
            });

            modelBuilder.Entity<SupplyOrderDetails>(entity =>
            {
                entity.Property(e => e.Created).HasDefaultValueSql("(getdate())");

                entity.Property(e => e.IsDeleted)
                    .IsRequired()
                    .HasDefaultValueSql("(CONVERT([bit],(0)))");

                entity.Property(e => e.Modified).HasDefaultValueSql("(getdate())");

                entity.HasOne(d => d.Order)
                    .WithMany(p => p.SupplyOrderDetails)
                    .HasForeignKey(d => d.OrderId);

                entity.HasOne(d => d.Product)
                    .WithMany(p => p.SupplyOrderDetails)
                    .HasForeignKey(d => d.ProductId);
            });

            modelBuilder.Entity<SupplyOrderPaymentDetails>(entity =>
            {
                entity.HasIndex(e => e.BankDepositId);

                entity.HasIndex(e => e.SupplyOrderId)
                    .IsUnique();

                entity.HasOne(d => d.BankDeposit)
                    .WithMany(p => p.SupplyOrderPaymentDetails)
                    .HasForeignKey(d => d.BankDepositId);

                entity.HasOne(d => d.SupplyOrder)
                    .WithOne(p => p.SupplyOrderPaymentDetails)
                    .HasForeignKey<SupplyOrderPaymentDetails>(d => d.SupplyOrderId);
            });

            modelBuilder.Entity<SupplyOrderPayments>(entity =>
            {
                entity.HasIndex(e => e.SupplyOrderId);

                entity.HasIndex(e => e.UserId);

                entity.Property(e => e.Created).HasDefaultValueSql("(getdate())");

                entity.Property(e => e.IsDeleted)
                    .IsRequired()
                    .HasDefaultValueSql("(CONVERT([bit],(0)))");

                entity.Property(e => e.Modified).HasDefaultValueSql("(getdate())");

                entity.HasOne(d => d.SupplyOrder)
                    .WithMany(p => p.SupplyOrderPayments)
                    .HasForeignKey(d => d.SupplyOrderId);

                entity.HasOne(d => d.User)
                    .WithMany(p => p.SupplyOrderPayments)
                    .HasForeignKey(d => d.UserId);
            });

            modelBuilder.Entity<SupplyOrderStates>(entity =>
            {
                entity.Property(e => e.Created).HasDefaultValueSql("(getdate())");

                entity.Property(e => e.IsDeleted)
                    .IsRequired()
                    .HasDefaultValueSql("(CONVERT([bit],(0)))");

                entity.Property(e => e.Modified).HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Name).HasMaxLength(50);
            });

            modelBuilder.Entity<SupplyOrders>(entity =>
            {
                entity.HasIndex(e => e.AcceptedById);

                entity.HasIndex(e => e.AssignedToId);

                entity.HasIndex(e => e.CreatedById);

                entity.HasIndex(e => e.FromId);

                entity.HasIndex(e => e.OrderNumber)
                    .IsUnique()
                    .HasFilter("([OrderNumber] IS NOT NULL)");

                entity.HasIndex(e => e.OrderStateId);

                entity.HasIndex(e => e.PaymentMethodId);

                entity.HasIndex(e => e.ReceivedById);

                entity.HasIndex(e => e.ToId);

                entity.HasIndex(e => e.TripId);

                entity.Property(e => e.Created).HasDefaultValueSql("(getdate())");

                entity.Property(e => e.IsDeleted)
                    .IsRequired()
                    .HasDefaultValueSql("(CONVERT([bit],(0)))");

                entity.Property(e => e.Modified).HasDefaultValueSql("(getdate())");

                entity.Property(e => e.OrderNumber)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.PaymentStatus)
                    .IsRequired()
                    .HasDefaultValueSql("(CONVERT([bit],(0)))");

                entity.HasOne(d => d.AcceptedBy)
                    .WithMany(p => p.SupplyOrdersAcceptedBy)
                    .HasForeignKey(d => d.AcceptedById);

                entity.HasOne(d => d.AssignedTo)
                    .WithMany(p => p.SupplyOrdersAssignedTo)
                    .HasForeignKey(d => d.AssignedToId);

                entity.HasOne(d => d.CreatedBy)
                    .WithMany(p => p.SupplyOrdersCreatedBy)
                    .HasForeignKey(d => d.CreatedById);

                entity.HasOne(d => d.From)
                    .WithMany(p => p.SupplyOrdersFrom)
                    .HasForeignKey(d => d.FromId)
                    .OnDelete(DeleteBehavior.ClientSetNull);

                entity.HasOne(d => d.OrderState)
                    .WithMany(p => p.SupplyOrders)
                    .HasForeignKey(d => d.OrderStateId);

                entity.HasOne(d => d.PaymentMethod)
                    .WithMany(p => p.SupplyOrders)
                    .HasForeignKey(d => d.PaymentMethodId);

                entity.HasOne(d => d.ReceivedBy)
                    .WithMany(p => p.SupplyOrdersReceivedBy)
                    .HasForeignKey(d => d.ReceivedById);

                entity.HasOne(d => d.To)
                    .WithMany(p => p.SupplyOrdersTo)
                    .HasForeignKey(d => d.ToId)
                    .OnDelete(DeleteBehavior.ClientSetNull);

                entity.HasOne(d => d.Trip)
                    .WithMany(p => p.SupplyOrders)
                    .HasForeignKey(d => d.TripId);
            });

            modelBuilder.Entity<Trips>(entity =>
            {
                entity.HasIndex(e => e.AcceptedById);

                entity.HasIndex(e => e.AssignedToId);

                entity.HasIndex(e => e.CreatedById);

                entity.HasIndex(e => e.FromId);

                entity.HasIndex(e => e.TripStateId);

                entity.Property(e => e.Created).HasDefaultValueSql("(getdate())");

                entity.Property(e => e.IsDeleted)
                    .IsRequired()
                    .HasDefaultValueSql("(CONVERT([bit],(0)))");

                entity.Property(e => e.Modified).HasDefaultValueSql("(getdate())");

                entity.Property(e => e.TripNumber).HasMaxLength(14);

                entity.HasOne(d => d.AcceptedBy)
                    .WithMany(p => p.TripsAcceptedBy)
                    .HasForeignKey(d => d.AcceptedById);

                entity.HasOne(d => d.AssignedTo)
                    .WithMany(p => p.TripsAssignedTo)
                    .HasForeignKey(d => d.AssignedToId);

                entity.HasOne(d => d.CreatedBy)
                    .WithMany(p => p.TripsCreatedBy)
                    .HasForeignKey(d => d.CreatedById);

                entity.HasOne(d => d.From)
                    .WithMany(p => p.Trips)
                    .HasForeignKey(d => d.FromId);

                entity.HasOne(d => d.TripState)
                    .WithMany(p => p.Trips)
                    .HasForeignKey(d => d.TripStateId);
            });

            modelBuilder.Entity<Units>(entity =>
            {
                entity.Property(e => e.Created).HasDefaultValueSql("(getdate())");

                entity.Property(e => e.IsDeleted)
                    .IsRequired()
                    .HasDefaultValueSql("(CONVERT([bit],(0)))");

                entity.Property(e => e.Modified).HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Name).HasMaxLength(50);
            });

            modelBuilder.Entity<WareHouseProducts>(entity =>
            {
                entity.HasIndex(e => e.ProductId);

                entity.HasIndex(e => e.WarehouseId);

                entity.Property(e => e.AssignedQty).HasDefaultValueSql("((0))");

                entity.Property(e => e.Created).HasDefaultValueSql("(getdate())");

                entity.Property(e => e.IsDeleted)
                    .IsRequired()
                    .HasDefaultValueSql("(CONVERT([bit],(0)))");

                entity.Property(e => e.Modified).HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Quantity).HasDefaultValueSql("((0))");

                entity.HasOne(d => d.Product)
                    .WithMany(p => p.WareHouseProducts)
                    .HasForeignKey(d => d.ProductId);

                entity.HasOne(d => d.Warehouse)
                    .WithMany(p => p.WareHouseProducts)
                    .HasForeignKey(d => d.WarehouseId);
            });

            modelBuilder.Entity<Warehouses>(entity =>
            {
                entity.HasIndex(e => e.AreaId);

                entity.HasIndex(e => e.LinkedToWarehouseId);

                entity.HasIndex(e => e.WarehouseTypeId);

                entity.Property(e => e.Address).HasMaxLength(50);

                entity.Property(e => e.Created).HasDefaultValueSql("(getdate())");

                entity.Property(e => e.IsDeleted)
                    .IsRequired()
                    .HasDefaultValueSql("(CONVERT([bit],(0)))");

                entity.Property(e => e.Modified).HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Name).HasMaxLength(50);

                entity.Property(e => e.Phone).HasMaxLength(50);

                entity.HasOne(d => d.Area)
                    .WithMany(p => p.Warehouses)
                    .HasForeignKey(d => d.AreaId);

                entity.HasOne(d => d.LinkedToWarehouse)
                    .WithMany(p => p.InverseLinkedToWarehouse)
                    .HasForeignKey(d => d.LinkedToWarehouseId);

                entity.HasOne(d => d.WarehouseType)
                    .WithMany(p => p.Warehouses)
                    .HasForeignKey(d => d.WarehouseTypeId);
            });

            modelBuilder.Entity<Zemma>(entity =>
            {
                entity.HasIndex(e => e.UserId);

                entity.Property(e => e.Value).HasColumnName("value");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.Zemma)
                    .HasForeignKey(d => d.UserId);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
