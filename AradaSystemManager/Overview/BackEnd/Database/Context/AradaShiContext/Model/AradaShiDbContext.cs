using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace AradaSystemManager.Overview.BackEnd.Database.Context.AradaShiContext.Model
{
    public partial class AradaShiDbContext : DbContext
    {
        public AradaShiDbContext()
        {
        }

        public AradaShiDbContext(DbContextOptions<AradaShiDbContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Advertisement> Advertisements { get; set; }
        public virtual DbSet<AdvertisementAgeGroup> AdvertisementAgeGroups { get; set; }
        public virtual DbSet<AdvertisementPage> AdvertisementPages { get; set; }
        public virtual DbSet<AdvertisementType> AdvertisementTypes { get; set; }
        public virtual DbSet<AdvertiserInfo> AdvertiserInfos { get; set; }
        public virtual DbSet<AmoleAccountInfo> AmoleAccountInfos { get; set; }
        public virtual DbSet<AmoleHeaderInfo> AmoleHeaderInfos { get; set; }
        public virtual DbSet<AttachmentType> AttachmentTypes { get; set; }
        public virtual DbSet<Bank> Banks { get; set; }
        public virtual DbSet<BankSetting> BankSettings { get; set; }
        public virtual DbSet<Card> Cards { get; set; }
        public virtual DbSet<CardOut> CardOuts { get; set; }
        public virtual DbSet<CardProvidersTelecom> CardProvidersTelecoms { get; set; }
        public virtual DbSet<ClientAccount> ClientAccounts { get; set; }
        public virtual DbSet<ClientAddress> ClientAddresses { get; set; }
        public virtual DbSet<ClientHager> ClientHagers { get; set; }
        public virtual DbSet<ClientInfo> ClientInfos { get; set; }
        public virtual DbSet<Deposit> Deposits { get; set; }
        public virtual DbSet<DepositInvoice> DepositInvoices { get; set; }
        public virtual DbSet<ExceptionLog> ExceptionLogs { get; set; }
        public virtual DbSet<Game> Games { get; set; }
        public virtual DbSet<GameAdmissionFee> GameAdmissionFees { get; set; }
        public virtual DbSet<GameGenre> GameGenres { get; set; }
        public virtual DbSet<GamePlayer> GamePlayers { get; set; }
        public virtual DbSet<GameQuestionRecorder> GameQuestionRecorders { get; set; }
        public virtual DbSet<GameRevenuLog> GameRevenuLogs { get; set; }
        public virtual DbSet<GameSetting> GameSettings { get; set; }
        public virtual DbSet<GameSponserInfo> GameSponserInfos { get; set; }
        public virtual DbSet<GameType> GameTypes { get; set; }
        public virtual DbSet<GameplayAlgorithm> GameplayAlgorithms { get; set; }
        public virtual DbSet<GebeyaOrder> GebeyaOrders { get; set; }
        public virtual DbSet<GetNewId> GetNewIds { get; set; }
        public virtual DbSet<GiftLog> GiftLogs { get; set; }
        public virtual DbSet<GiftMode> GiftModes { get; set; }
        public virtual DbSet<GiftSetting> GiftSettings { get; set; }
        public virtual DbSet<Hager> Hagers { get; set; }
        public virtual DbSet<HagerOut> HagerOuts { get; set; }
        public virtual DbSet<HelloCashBank> HelloCashBanks { get; set; }
        public virtual DbSet<HelloCashHeaderInfo> HelloCashHeaderInfos { get; set; }
        public virtual DbSet<MinimumGamePlayer> MinimumGamePlayers { get; set; }
        public virtual DbSet<MinimumTransactionAmount> MinimumTransactionAmounts { get; set; }
        public virtual DbSet<OrderShippingAddress> OrderShippingAddresses { get; set; }
        public virtual DbSet<PlayerScore> PlayerScores { get; set; }
        public virtual DbSet<Product> Products { get; set; }
        public virtual DbSet<ProductAddress> ProductAddresses { get; set; }
        public virtual DbSet<ProductMedium> ProductMedia { get; set; }
        public virtual DbSet<ProductOrder> ProductOrders { get; set; }
        public virtual DbSet<ProductPaymentOption> ProductPaymentOptions { get; set; }
        public virtual DbSet<ProductRating> ProductRatings { get; set; }
        public virtual DbSet<ProductSeller> ProductSellers { get; set; }
        public virtual DbSet<ProductSetting> ProductSettings { get; set; }
        public virtual DbSet<ProductSize> ProductSizes { get; set; }
        public virtual DbSet<ProductSizeCategory> ProductSizeCategories { get; set; }
        public virtual DbSet<ProductTag> ProductTags { get; set; }
        public virtual DbSet<Question> Questions { get; set; }
        public virtual DbSet<QuestionChoise> QuestionChoises { get; set; }
        public virtual DbSet<QuestionDifficultyMode> QuestionDifficultyModes { get; set; }
        public virtual DbSet<QuestionType> QuestionTypes { get; set; }
        public virtual DbSet<ServiceChargeRate> ServiceChargeRates { get; set; }
        public virtual DbSet<SessionLog> SessionLogs { get; set; }
        public virtual DbSet<Shelf> Shelves { get; set; }
        public virtual DbSet<Souq> Souqs { get; set; }
        public virtual DbSet<SouqServiceFeeLog> SouqServiceFeeLogs { get; set; }
        public virtual DbSet<SouqSetting> SouqSettings { get; set; }
        public virtual DbSet<SponsoredGameInfo> SponsoredGameInfos { get; set; }
        public virtual DbSet<StickerRepo> StickerRepos { get; set; }
        public virtual DbSet<ViewAccountBalance> ViewAccountBalances { get; set; }
        public virtual DbSet<ViewAdvertisement> ViewAdvertisements { get; set; }
        public virtual DbSet<ViewAdvertisementPage> ViewAdvertisementPages { get; set; }
        public virtual DbSet<ViewAmoleHeaderInfo> ViewAmoleHeaderInfos { get; set; }
        public virtual DbSet<ViewAnimatedSticker> ViewAnimatedStickers { get; set; }
        public virtual DbSet<ViewCard> ViewCards { get; set; }
        public virtual DbSet<ViewCardProvider> ViewCardProviders { get; set; }
        public virtual DbSet<ViewClientAccount> ViewClientAccounts { get; set; }
        public virtual DbSet<ViewClientGame> ViewClientGames { get; set; }
        public virtual DbSet<ViewClientGameFee> ViewClientGameFees { get; set; }
        public virtual DbSet<ViewClientId> ViewClientIds { get; set; }
        public virtual DbSet<ViewClientInfo> ViewClientInfos { get; set; }
        public virtual DbSet<ViewDeposit> ViewDeposits { get; set; }
        public virtual DbSet<ViewGame> ViewGames { get; set; }
        public virtual DbSet<ViewGameAdmissionFee> ViewGameAdmissionFees { get; set; }
        public virtual DbSet<ViewGameGenre> ViewGameGenres { get; set; }
        public virtual DbSet<ViewGamePlayer> ViewGamePlayers { get; set; }
        public virtual DbSet<ViewGameSetting> ViewGameSettings { get; set; }
        public virtual DbSet<ViewGameSponserInfo> ViewGameSponserInfos { get; set; }
        public virtual DbSet<ViewGameStatus> ViewGameStatuses { get; set; }
        public virtual DbSet<ViewGameType> ViewGameTypes { get; set; }
        public virtual DbSet<ViewGameplayAlgorithm> ViewGameplayAlgorithms { get; set; }
        public virtual DbSet<ViewGiftLog> ViewGiftLogs { get; set; }
        public virtual DbSet<ViewHager> ViewHagers { get; set; }
        public virtual DbSet<ViewHelloCashHeaderInfo> ViewHelloCashHeaderInfos { get; set; }
        public virtual DbSet<ViewLeaderboard> ViewLeaderboards { get; set; }
        public virtual DbSet<ViewMinTransactionAmount> ViewMinTransactionAmounts { get; set; }
        public virtual DbSet<ViewMinimumPlayer> ViewMinimumPlayers { get; set; }
        public virtual DbSet<ViewPlayerScore> ViewPlayerScores { get; set; }
        public virtual DbSet<ViewProduct> ViewProducts { get; set; }
        public virtual DbSet<ViewProductAddress> ViewProductAddresses { get; set; }
        public virtual DbSet<ViewProductMedium> ViewProductMedia { get; set; }
        public virtual DbSet<ViewProductRating> ViewProductRatings { get; set; }
        public virtual DbSet<ViewProductSetting> ViewProductSettings { get; set; }
        public virtual DbSet<ViewProductTag> ViewProductTags { get; set; }
        public virtual DbSet<ViewQuestion> ViewQuestions { get; set; }
        public virtual DbSet<ViewQuestionChooise> ViewQuestionChooises { get; set; }
        public virtual DbSet<ViewServiceChargeRate> ViewServiceChargeRates { get; set; }
        public virtual DbSet<ViewShelf> ViewShelves { get; set; }
        public virtual DbSet<ViewSouqSetting> ViewSouqSettings { get; set; }
        public virtual DbSet<ViewSponsoredGameInfo> ViewSponsoredGameInfos { get; set; }
        public virtual DbSet<ViewUsersHager> ViewUsersHagers { get; set; }
        public virtual DbSet<ViewWithdrawal> ViewWithdrawals { get; set; }
        public virtual DbSet<ViwProductAddress> ViwProductAddresses { get; set; }
        public virtual DbSet<Withdrawal> Withdrawals { get; set; }
        public virtual DbSet<WithdrawalInvoice> WithdrawalInvoices { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning Please Set User Id and Password
                optionsBuilder.UseSqlServer("Server=tcp:aradashi.database.windows.net,1433;initial catalog=AradaShiDb;user id=**;password=**;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "SQL_Latin1_General_CP1_CI_AS");

            modelBuilder.Entity<Advertisement>(entity =>
            {
                entity.ToTable("Advertisement", "ad");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.AdPage)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ad_page");

                entity.Property(e => e.AdType)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ad_type");

                entity.Property(e => e.Advertisement1).HasColumnName("advertisement");

                entity.Property(e => e.AdvertiserId).HasColumnName("advertiser_id");

                entity.Property(e => e.AgeGroup)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("age_group");

                entity.Property(e => e.Duration).HasColumnName("duration");

                entity.Property(e => e.EndedDate)
                    .HasColumnType("datetime")
                    .HasColumnName("ended_date");

                entity.Property(e => e.PhotoUrl).HasColumnName("photo_url");

                entity.Property(e => e.PopupOption)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("popup_option")
                    .HasDefaultValueSql("('BEFORE')")
                    .HasComment("BEFORE,AFTER,BEFORE-SINGLE");

                entity.Property(e => e.RegistrationDate)
                    .HasColumnType("datetime")
                    .HasColumnName("registration_date");

                entity.Property(e => e.Schedule)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("schedule")
                    .HasDefaultValueSql("('ALL-DAY')")
                    .HasComment("ALL-DAY,PEAK HOUR, HALF-DAY");

                entity.Property(e => e.StartingDate)
                    .HasColumnType("datetime")
                    .HasColumnName("starting_date");

                entity.Property(e => e.Status)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("status");

                entity.HasOne(d => d.Advertiser)
                    .WithMany(p => p.Advertisements)
                    .HasForeignKey(d => d.AdvertiserId)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK_Advertisement_AdvertiserInfo");
            });

            modelBuilder.Entity<AdvertisementAgeGroup>(entity =>
            {
                entity.HasKey(e => e.AgeGroup)
                    .HasName("PK_AdvertisementAgeGroup_1");

                entity.ToTable("AdvertisementAgeGroup", "ad");

                entity.Property(e => e.AgeGroup)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("age_group");

                entity.Property(e => e.Status)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("status");
            });

            modelBuilder.Entity<AdvertisementPage>(entity =>
            {
                entity.ToTable("AdvertisementPage", "ad");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Sitemap).HasColumnName("sitemap");

                entity.Property(e => e.Status)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("status");
            });

            modelBuilder.Entity<AdvertisementType>(entity =>
            {
                entity.HasKey(e => e.Name);

                entity.ToTable("AdvertisementType", "ad");

                entity.Property(e => e.Name)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("name");
            });

            modelBuilder.Entity<AdvertiserInfo>(entity =>
            {
                entity.ToTable("AdvertiserInfo", "ad");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Company)
                    .HasMaxLength(500)
                    .HasColumnName("company");

                entity.Property(e => e.ContactName)
                    .HasMaxLength(100)
                    .HasColumnName("contact_name");

                entity.Property(e => e.ContactPhone)
                    .HasMaxLength(13)
                    .IsUnicode(false)
                    .HasColumnName("contact_phone");

                entity.Property(e => e.RegistrationDate)
                    .HasColumnType("datetime")
                    .HasColumnName("registration_date");

                entity.Property(e => e.Tin)
                    .HasMaxLength(500)
                    .HasColumnName("tin");
            });

            modelBuilder.Entity<AmoleAccountInfo>(entity =>
            {
                entity.ToTable("AmoleAccountInfo", "aradashi");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.AccountStatus)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("account_status");

                entity.Property(e => e.BirthDate)
                    .HasColumnType("date")
                    .HasColumnName("birth_date");

                entity.Property(e => e.City)
                    .HasMaxLength(50)
                    .HasColumnName("city");

                entity.Property(e => e.ClientId).HasColumnName("client_id");

                entity.Property(e => e.Country)
                    .HasMaxLength(50)
                    .HasColumnName("country");

                entity.Property(e => e.FirstName)
                    .HasMaxLength(50)
                    .HasColumnName("first_name");

                entity.Property(e => e.LastName)
                    .HasMaxLength(50)
                    .HasColumnName("last_name");

                entity.Property(e => e.Nationality)
                    .HasMaxLength(50)
                    .HasColumnName("nationality");

                entity.Property(e => e.RegistrationDate)
                    .HasColumnType("datetime")
                    .HasColumnName("registration_date");

                entity.Property(e => e.Residency)
                    .HasMaxLength(50)
                    .HasColumnName("residency");

                entity.Property(e => e.SecondName)
                    .HasMaxLength(50)
                    .HasColumnName("second_name");

                entity.HasOne(d => d.Client)
                    .WithMany(p => p.AmoleAccountInfos)
                    .HasForeignKey(d => d.ClientId)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK_AmoleAccountInfo_ClientInfo");
            });

            modelBuilder.Entity<AmoleHeaderInfo>(entity =>
            {
                entity.ToTable("AmoleHeaderInfo", "aradashi");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Ip)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("ip");

                entity.Property(e => e.Passwd)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("passwd");

                entity.Property(e => e.Signature)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("signature");

                entity.Property(e => e.Username)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("username");
            });

            modelBuilder.Entity<AttachmentType>(entity =>
            {
                entity.HasKey(e => e.Name);

                entity.ToTable("AttachmentType", "ago");

                entity.Property(e => e.Name)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("name");
            });

            modelBuilder.Entity<Bank>(entity =>
            {
                entity.ToTable("Bank", "aradashi");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Name)
                    .HasMaxLength(100)
                    .HasColumnName("name");

                entity.Property(e => e.Status)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("status");
            });

            modelBuilder.Entity<BankSetting>(entity =>
            {
                entity.ToTable("BankSetting", "aradashi");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.BankId).HasColumnName("bank_id");

                entity.Property(e => e.Service)
                    .HasMaxLength(30)
                    .HasColumnName("service");

                entity.Property(e => e.Status)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("status");

                entity.HasOne(d => d.Bank)
                    .WithMany(p => p.BankSettings)
                    .HasForeignKey(d => d.BankId)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK_BankSetting_Bank");
            });

            modelBuilder.Entity<Card>(entity =>
            {
                entity.ToTable("Card", "ago");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.CardAmount).HasColumnName("card_amount");

                entity.Property(e => e.ExpiryDate)
                    .HasColumnType("datetime")
                    .HasColumnName("expiry_date");

                entity.Property(e => e.RegistrationDate)
                    .HasColumnType("datetime")
                    .HasColumnName("registration_date");

                entity.Property(e => e.SerialNumber)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("serial_number");

                entity.Property(e => e.Status)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("status");

                entity.Property(e => e.SupplierName)
                    .HasMaxLength(50)
                    .HasColumnName("supplier_name");

                entity.Property(e => e.Telecom)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("telecom");

                entity.Property(e => e.VoucherPin)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("voucher_pin");

                entity.HasOne(d => d.TelecomNavigation)
                    .WithMany(p => p.Cards)
                    .HasForeignKey(d => d.Telecom)
                    .HasConstraintName("FK_Card_CardProvidersTelecom");
            });

            modelBuilder.Entity<CardOut>(entity =>
            {
                entity.ToTable("CardOut", "ago");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.CardId).HasColumnName("card_id");

                entity.Property(e => e.CardoutDate)
                    .HasColumnType("datetime")
                    .HasColumnName("cardout_date");

                entity.Property(e => e.ClientAccountId).HasColumnName("client_account_id");

                entity.Property(e => e.Reference)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("reference");

                entity.HasOne(d => d.Card)
                    .WithMany(p => p.CardOuts)
                    .HasForeignKey(d => d.CardId)
                    .OnDelete(DeleteBehavior.SetNull)
                    .HasConstraintName("FK_CardOut_Card");

                entity.HasOne(d => d.ClientAccount)
                    .WithMany(p => p.CardOuts)
                    .HasForeignKey(d => d.ClientAccountId)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK_CardOut_ClientAccount");
            });

            modelBuilder.Entity<CardProvidersTelecom>(entity =>
            {
                entity.HasKey(e => e.Name);

                entity.ToTable("CardProvidersTelecom", "ago");

                entity.Property(e => e.Name)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("name");

                entity.Property(e => e.Status)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("status");
            });

            modelBuilder.Entity<ClientAccount>(entity =>
            {
                entity.ToTable("ClientAccount", "aradashi");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Balance)
                    .HasColumnType("money")
                    .HasColumnName("balance");

                entity.Property(e => e.ClientId).HasColumnName("client_id");

                entity.Property(e => e.ModifiedDate)
                    .HasColumnType("datetime")
                    .HasColumnName("modified_date");

                entity.Property(e => e.RegistrationDate)
                    .HasColumnType("datetime")
                    .HasColumnName("registration_date");

                entity.HasOne(d => d.Client)
                    .WithMany(p => p.ClientAccounts)
                    .HasForeignKey(d => d.ClientId)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK_ClientAccount_ClientInfo");
            });

            modelBuilder.Entity<ClientAddress>(entity =>
            {
                entity.ToTable("ClientAddress", "aradashi");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.City)
                    .HasMaxLength(50)
                    .HasColumnName("city");

                entity.Property(e => e.ClientId).HasColumnName("client_id");

                entity.Property(e => e.Country)
                    .HasMaxLength(50)
                    .HasColumnName("country");

                entity.Property(e => e.LastLocation)
                    .HasMaxLength(80)
                    .IsUnicode(false)
                    .HasColumnName("last_location");

                entity.Property(e => e.ModifiedDate)
                    .HasColumnType("datetime")
                    .HasColumnName("modified_date");

                entity.HasOne(d => d.Client)
                    .WithMany(p => p.ClientAddresses)
                    .HasForeignKey(d => d.ClientId)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK_ClientAddress_ClientInfo");
            });

            modelBuilder.Entity<ClientHager>(entity =>
            {
                entity.ToTable("ClientHager", "ago");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Available).HasColumnName("available");

                entity.Property(e => e.ClientId).HasColumnName("client_id");

                entity.Property(e => e.ModifiedDate)
                    .HasColumnType("datetime")
                    .HasColumnName("modified_date");

                entity.Property(e => e.RegistrationDate)
                    .HasColumnType("datetime")
                    .HasColumnName("registration_date");

                entity.HasOne(d => d.Client)
                    .WithMany(p => p.ClientHagers)
                    .HasForeignKey(d => d.ClientId)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK_ClientHager_ClientInfo");
            });

            modelBuilder.Entity<ClientInfo>(entity =>
            {
                entity.ToTable("ClientInfo", "aradashi");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.AgeGroup)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("age_group")
                    .HasDefaultValueSql("((21)-(25))");

                entity.Property(e => e.Firstname)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("firstname")
                    .HasDefaultValueSql("(N'Arada')");

                entity.Property(e => e.LastActivityDate)
                    .HasColumnType("datetime")
                    .HasColumnName("last_activity_date");

                entity.Property(e => e.Lastname)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("lastname")
                    .HasDefaultValueSql("(N'AradaUser')");

                entity.Property(e => e.Phone)
                    .HasMaxLength(18)
                    .IsUnicode(false)
                    .HasColumnName("phone");

                entity.Property(e => e.RegistrationDate)
                    .HasColumnType("datetime")
                    .HasColumnName("registration_date");

                entity.Property(e => e.Status)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("status");

                entity.Property(e => e.TelegramId)
                    .IsRequired()
                    .HasMaxLength(60)
                    .IsUnicode(false)
                    .HasColumnName("telegram_id");

                entity.Property(e => e.Username)
                    .HasMaxLength(40)
                    .HasColumnName("username");

                entity.HasOne(d => d.AgeGroupNavigation)
                    .WithMany(p => p.ClientInfos)
                    .HasForeignKey(d => d.AgeGroup)
                    .OnDelete(DeleteBehavior.SetNull)
                    .HasConstraintName("FK_ClientInfo_ClientInfo");
            });

            modelBuilder.Entity<Deposit>(entity =>
            {
                entity.ToTable("Deposit", "aradashi");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Amount)
                    .HasColumnType("money")
                    .HasColumnName("amount");

                entity.Property(e => e.BankId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("bank_id");

                entity.Property(e => e.ClientAccountId).HasColumnName("client_account_id");

                entity.Property(e => e.DepositDate)
                    .HasColumnType("datetime")
                    .HasColumnName("deposit_date");

                entity.Property(e => e.PaymentMethod)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("payment_method");

                entity.Property(e => e.Status)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("status")
                    .HasDefaultValueSql("('REQUESTED')");

                entity.Property(e => e.TtNumber)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("tt_number");

                entity.HasOne(d => d.ClientAccount)
                    .WithMany(p => p.Deposits)
                    .HasForeignKey(d => d.ClientAccountId)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK_Deposit_ClientAccount");
            });

            modelBuilder.Entity<DepositInvoice>(entity =>
            {
                entity.ToTable("DepositInvoice", "aradashi");

                entity.HasIndex(e => e.InvoiceNumber, "UK_DepositInvoice")
                    .IsUnique();

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.DepositId).HasColumnName("deposit_id");

                entity.Property(e => e.InvoiceNumber)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("invoice_number");

                entity.Property(e => e.RegistrationDate)
                    .HasColumnType("datetime")
                    .HasColumnName("registration_date");

                entity.Property(e => e.Status)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("status")
                    .HasDefaultValueSql("('INACTIVE')");

                entity.HasOne(d => d.Deposit)
                    .WithMany(p => p.DepositInvoices)
                    .HasForeignKey(d => d.DepositId)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK_DepositInvoice_Deposit");
            });

            modelBuilder.Entity<ExceptionLog>(entity =>
            {
                entity.ToTable("ExceptionLog", "aradashi");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Hresult).HasColumnName("hresult");

                entity.Property(e => e.InnerHresult).HasColumnName("inner_hresult");

                entity.Property(e => e.InnerMessage).HasColumnName("inner_message");

                entity.Property(e => e.InnerSource).HasColumnName("inner_source");

                entity.Property(e => e.InnerStackTrace).HasColumnName("inner_stack_trace");

                entity.Property(e => e.Message).HasColumnName("message");

                entity.Property(e => e.RegistrationDate)
                    .HasColumnType("datetime")
                    .HasColumnName("registration_date");

                entity.Property(e => e.Source).HasColumnName("source");

                entity.Property(e => e.StackTrace).HasColumnName("stack_trace");
            });

            modelBuilder.Entity<Game>(entity =>
            {
                entity.ToTable("Game", "aradagame");

                entity.HasComment("");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasComment("Primary Key of the table");

                entity.Property(e => e.AssignedAlgorithm).HasColumnName("assigned_algorithm");

                entity.Property(e => e.Creator)
                    .HasColumnName("creator")
                    .HasComment("Used to identify the game creator");

                entity.Property(e => e.EndingDate)
                    .HasColumnType("datetime")
                    .HasColumnName("ending_date")
                    .HasComment("Used to identify the game ending date and time");

                entity.Property(e => e.GameFee)
                    .HasColumnType("money")
                    .HasColumnName("game_fee")
                    .HasComment("Used to identify the interance fee of the game");

                entity.Property(e => e.GameGenre)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("game_genre")
                    .HasComment("Used to identify the game genre");

                entity.Property(e => e.GameSchedule)
                    .HasColumnType("datetime")
                    .HasColumnName("game_schedule")
                    .HasComment("Used to set the starting date and time of the game");

                entity.Property(e => e.GameScheduleEt)
                    .HasMaxLength(50)
                    .HasColumnName("game_schedule_et");

                entity.Property(e => e.GameType)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("game_type")
                    .HasComment("Used to identify the game type");

                entity.Property(e => e.IsNumberOfQuestionCustom)
                    .HasColumnName("is_number_of_question_custom")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.RegistrationDate)
                    .HasColumnType("datetime")
                    .HasColumnName("registration_date")
                    .HasComment("Used to identify when the game is created");

                entity.Property(e => e.StartingDate)
                    .HasColumnType("datetime")
                    .HasColumnName("starting_date")
                    .HasComment("Used to identify the starting date of the game");

                entity.Property(e => e.Status)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("status")
                    .HasComment("Used to identify the game status (Started/Created/Ended)");

                entity.Property(e => e.TotalQuestions)
                    .HasColumnName("total_questions")
                    .HasDefaultValueSql("((12))")
                    .HasComment("Used to identify the total questions of the game");

                entity.HasOne(d => d.AssignedAlgorithmNavigation)
                    .WithMany(p => p.Games)
                    .HasForeignKey(d => d.AssignedAlgorithm)
                    .OnDelete(DeleteBehavior.SetNull)
                    .HasConstraintName("FK_Game_GameplayAlgorithm");

                entity.HasOne(d => d.CreatorNavigation)
                    .WithMany(p => p.Games)
                    .HasForeignKey(d => d.Creator)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Game_ClientInfo");

                entity.HasOne(d => d.GameGenreNavigation)
                    .WithMany(p => p.Games)
                    .HasForeignKey(d => d.GameGenre)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Game_GameGenre");

                entity.HasOne(d => d.GameTypeNavigation)
                    .WithMany(p => p.Games)
                    .HasForeignKey(d => d.GameType)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Game_GameType");
            });

            modelBuilder.Entity<GameAdmissionFee>(entity =>
            {
                entity.ToTable("GameAdmissionFee", "aradagame");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Fee)
                    .HasColumnType("money")
                    .HasColumnName("fee");

                entity.Property(e => e.GameGenreId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("game_genre_id");

                entity.HasOne(d => d.GameGenre)
                    .WithMany(p => p.GameAdmissionFees)
                    .HasForeignKey(d => d.GameGenreId)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK_GameAdmissionFee_GameGenre");
            });

            modelBuilder.Entity<GameGenre>(entity =>
            {
                entity.ToTable("GameGenre", "aradagame");

                entity.Property(e => e.Id)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("id");

                entity.Property(e => e.Genre)
                    .HasMaxLength(50)
                    .HasColumnName("genre");

                entity.Property(e => e.Status)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("status");
            });

            modelBuilder.Entity<GamePlayer>(entity =>
            {
                entity.ToTable("GamePlayers", "aradagame");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasComment("Primary Key of the table");

                entity.Property(e => e.EndedDate)
                    .HasColumnType("datetime")
                    .HasColumnName("ended_date")
                    .HasComment("used to identify the date and time when the player leave the game");

                entity.Property(e => e.GameId)
                    .HasColumnName("game_id")
                    .HasComment("Used to identify which game the player joined");

                entity.Property(e => e.IsHagerUsed).HasColumnName("is_hager_used");

                entity.Property(e => e.IsQuestionAnswered)
                    .HasColumnName("is_question_answered")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.IsReminderSent).HasColumnName("is_reminder_sent");

                entity.Property(e => e.LastQuestion)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("last_question")
                    .HasComment("Used to identify the last question of the player on the game");

                entity.Property(e => e.LastQuestionNumber)
                    .HasColumnName("last_question_number")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.LastSelctedAnswer).HasColumnName("last_selcted_answer");

                entity.Property(e => e.PlayerId)
                    .HasColumnName("player_id")
                    .HasComment("Used to identify which player joined the game");

                entity.Property(e => e.RegistrationDate)
                    .HasColumnType("datetime")
                    .HasColumnName("registration_date")
                    .HasComment("used to identify the date and time when the player joined the game");

                entity.Property(e => e.Status)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("status")
                    .HasComment("used to identify the status of the player on the game");

                entity.HasOne(d => d.Game)
                    .WithMany(p => p.GamePlayers)
                    .HasForeignKey(d => d.GameId)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK_GamePlayers_Game");

                entity.HasOne(d => d.LastQuestionNavigation)
                    .WithMany(p => p.GamePlayers)
                    .HasForeignKey(d => d.LastQuestion)
                    .HasConstraintName("FK_GamePlayers_Question");

                entity.HasOne(d => d.Player)
                    .WithMany(p => p.GamePlayers)
                    .HasForeignKey(d => d.PlayerId)
                    .HasConstraintName("FK_GamePlayers_ClientInfo");
            });

            modelBuilder.Entity<GameQuestionRecorder>(entity =>
            {
                entity.ToTable("GameQuestionRecorder", "aradagame");

                entity.HasComment("Records all asked questions on the game");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasComment("Primary key of the table");

                entity.Property(e => e.GameId)
                    .HasColumnName("game_id")
                    .HasComment("Used to identify the game");

                entity.Property(e => e.QuestionId)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("question_id")
                    .HasComment("Used to identify the question asked");

                entity.Property(e => e.RegistrationDate)
                    .HasColumnType("datetime")
                    .HasColumnName("registration_date")
                    .HasComment("");

                entity.HasOne(d => d.Game)
                    .WithMany(p => p.GameQuestionRecorders)
                    .HasForeignKey(d => d.GameId)
                    .HasConstraintName("FK_GameQuestionRecorder_Game");
            });

            modelBuilder.Entity<GameRevenuLog>(entity =>
            {
                entity.ToTable("GameRevenuLog", "aradagame");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.GameId).HasColumnName("game_id");

                entity.Property(e => e.RegistrationDate)
                    .HasColumnType("datetime")
                    .HasColumnName("registration_date");

                entity.Property(e => e.ServiceCharge)
                    .HasColumnType("money")
                    .HasColumnName("service_charge");

                entity.Property(e => e.ServiceChargeRate).HasColumnName("service_charge_rate");

                entity.Property(e => e.Vat)
                    .HasColumnType("money")
                    .HasColumnName("vat");

                entity.Property(e => e.VatRate).HasColumnName("vat_rate");

                entity.HasOne(d => d.Game)
                    .WithMany(p => p.GameRevenuLogs)
                    .HasForeignKey(d => d.GameId)
                    .HasConstraintName("FK_GameRevenuLog_Game");
            });

            modelBuilder.Entity<GameSetting>(entity =>
            {
                entity.ToTable("GameSetting", "aradagame");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.DifficultyLevel)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("difficulty_level")
                    .HasDefaultValueSql("('EASY')");

                entity.Property(e => e.GenreId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("genre_id");

                entity.Property(e => e.IsSponsored)
                    .HasColumnName("is_sponsored")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.MaxPlayer)
                    .HasColumnName("max_player")
                    .HasDefaultValueSql("((50))");

                entity.HasOne(d => d.Genre)
                    .WithMany(p => p.GameSettings)
                    .HasForeignKey(d => d.GenreId)
                    .OnDelete(DeleteBehavior.SetNull)
                    .HasConstraintName("FK_GameSetting_GameGenre");
            });

            modelBuilder.Entity<GameSponserInfo>(entity =>
            {
                entity.ToTable("GameSponserInfo", "aradagame");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.ClientId).HasColumnName("client_id");

                entity.Property(e => e.ContactNumber)
                    .HasMaxLength(13)
                    .IsUnicode(false)
                    .HasColumnName("contact_number");

                entity.Property(e => e.Name)
                    .HasMaxLength(100)
                    .HasColumnName("name");

                entity.Property(e => e.RegistrationDate)
                    .HasColumnType("datetime")
                    .HasColumnName("registration_date");

                entity.Property(e => e.Status)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("status")
                    .HasDefaultValueSql("('INACTIVE')");

                entity.Property(e => e.Tin)
                    .HasMaxLength(50)
                    .HasColumnName("tin");

                entity.HasOne(d => d.Client)
                    .WithMany(p => p.GameSponserInfos)
                    .HasForeignKey(d => d.ClientId)
                    .OnDelete(DeleteBehavior.SetNull)
                    .HasConstraintName("FK_GameSponserInfo_ClientInfo");
            });

            modelBuilder.Entity<GameType>(entity =>
            {
                entity.ToTable("GameType", "aradagame");

                entity.Property(e => e.Id)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("id");

                entity.Property(e => e.Type)
                    .HasMaxLength(50)
                    .HasColumnName("type");
            });

            modelBuilder.Entity<GameplayAlgorithm>(entity =>
            {
                entity.ToTable("GameplayAlgorithm", "aradagame");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.DifficultyMode)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("difficulty_mode");

                entity.Property(e => e.EasyQuestionPercent)
                    .HasColumnType("decimal(18, 0)")
                    .HasColumnName("easy_question_percent");

                entity.Property(e => e.Genre)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("genre");

                entity.Property(e => e.HardQuestionPercent)
                    .HasColumnType("decimal(18, 0)")
                    .HasColumnName("hard_question_percent");

                entity.Property(e => e.RegistrationDate)
                    .HasColumnType("datetime")
                    .HasColumnName("registration_date");

                entity.Property(e => e.Status)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("status");

                entity.Property(e => e.VeryEasyQuestionPercent)
                    .HasColumnType("decimal(18, 0)")
                    .HasColumnName("very_easy_question_percent");

                entity.Property(e => e.VeryHardQuestionPercent)
                    .HasColumnType("decimal(18, 0)")
                    .HasColumnName("very_hard_question_percent");

                entity.HasOne(d => d.DifficultyModeNavigation)
                    .WithMany(p => p.GameplayAlgorithms)
                    .HasForeignKey(d => d.DifficultyMode)
                    .OnDelete(DeleteBehavior.SetNull)
                    .HasConstraintName("FK_GameplayAlgorithm_QuestionDifficultyMode");

                entity.HasOne(d => d.GenreNavigation)
                    .WithMany(p => p.GameplayAlgorithms)
                    .HasForeignKey(d => d.Genre)
                    .OnDelete(DeleteBehavior.SetNull)
                    .HasConstraintName("FK_GameplayAlgorithm_GameGenre");
            });

            modelBuilder.Entity<GebeyaOrder>(entity =>
            {
                entity.ToTable("GebeyaOrder", "ago");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.ClientId).HasColumnName("client_id");

                entity.Property(e => e.OrderDate)
                    .HasColumnType("datetime")
                    .HasColumnName("order_date");

                entity.Property(e => e.Status)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("status");

                entity.HasOne(d => d.Client)
                    .WithMany(p => p.GebeyaOrders)
                    .HasForeignKey(d => d.ClientId)
                    .HasConstraintName("FK_GebeyaOrder_ClientInfo");
            });

            modelBuilder.Entity<GetNewId>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("Get_NewID");

                entity.Property(e => e.MyNewId).HasColumnName("MyNewID");
            });

            modelBuilder.Entity<GiftLog>(entity =>
            {
                entity.ToTable("GiftLog", "aradashi");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.ClientId).HasColumnName("client_id");

                entity.Property(e => e.GiftId).HasColumnName("gift_id");

                entity.Property(e => e.RegistrationDate)
                    .HasColumnType("datetime")
                    .HasColumnName("registration_date");

                entity.HasOne(d => d.Client)
                    .WithMany(p => p.GiftLogs)
                    .HasForeignKey(d => d.ClientId)
                    .OnDelete(DeleteBehavior.SetNull)
                    .HasConstraintName("FK_GiftLog_ClientInfo");

                entity.HasOne(d => d.Gift)
                    .WithMany(p => p.GiftLogs)
                    .HasForeignKey(d => d.GiftId)
                    .OnDelete(DeleteBehavior.SetNull)
                    .HasConstraintName("FK_GiftLog_GiftLog");
            });

            modelBuilder.Entity<GiftMode>(entity =>
            {
                entity.HasKey(e => e.Gift);

                entity.ToTable("GiftMode", "aradashi");

                entity.Property(e => e.Gift)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("gift");

                entity.Property(e => e.Description)
                    .HasMaxLength(100)
                    .HasColumnName("description");
            });

            modelBuilder.Entity<GiftSetting>(entity =>
            {
                entity.ToTable("GiftSetting", "aradashi");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Amount)
                    .HasColumnType("money")
                    .HasColumnName("amount");

                entity.Property(e => e.EndDate)
                    .HasColumnType("datetime")
                    .HasColumnName("end_date");

                entity.Property(e => e.GiftMode)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("gift_mode")
                    .HasDefaultValueSql("('NEW')");

                entity.Property(e => e.Message).HasColumnName("message");

                entity.Property(e => e.RegistrationDate)
                    .HasColumnType("datetime")
                    .HasColumnName("registration_date");

                entity.Property(e => e.RemainingGift).HasColumnName("remaining_gift");

                entity.Property(e => e.StartingDate)
                    .HasColumnType("datetime")
                    .HasColumnName("starting_date");

                entity.Property(e => e.Status)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("status");

                entity.Property(e => e.TotalGift).HasColumnName("total_gift");
            });

            modelBuilder.Entity<Hager>(entity =>
            {
                entity.ToTable("Hager", "ago");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Description)
                    .HasMaxLength(100)
                    .HasColumnName("description");

                entity.Property(e => e.Name)
                    .HasMaxLength(30)
                    .HasColumnName("name");

                entity.Property(e => e.Price)
                    .HasColumnType("money")
                    .HasColumnName("price");

                entity.Property(e => e.ProductCategoryId).HasColumnName("product_category_id");

                entity.Property(e => e.Qty).HasColumnName("qty");

                entity.Property(e => e.RegistrationDate)
                    .HasColumnType("datetime")
                    .HasColumnName("registration_date");

                entity.Property(e => e.Status)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("status");
            });

            modelBuilder.Entity<HagerOut>(entity =>
            {
                entity.ToTable("HagerOut", "ago");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.ClientAccountId).HasColumnName("client_account_id");

                entity.Property(e => e.HagerId).HasColumnName("hager_id");

                entity.Property(e => e.Reference)
                    .HasMaxLength(100)
                    .HasColumnName("reference");

                entity.Property(e => e.RegistrationDate)
                    .HasColumnType("datetime")
                    .HasColumnName("registration_date");

                entity.HasOne(d => d.ClientAccount)
                    .WithMany(p => p.HagerOuts)
                    .HasForeignKey(d => d.ClientAccountId)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK_HagerOut_ClientAccount");

                entity.HasOne(d => d.Hager)
                    .WithMany(p => p.HagerOuts)
                    .HasForeignKey(d => d.HagerId)
                    .OnDelete(DeleteBehavior.SetNull)
                    .HasConstraintName("FK_HagerOut_Hager");
            });

            modelBuilder.Entity<HelloCashBank>(entity =>
            {
                entity.ToTable("HelloCash_Banks", "aradashi");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Childs)
                    .HasMaxLength(50)
                    .HasColumnName("childs");

                entity.Property(e => e.Code)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("code");
            });

            modelBuilder.Entity<HelloCashHeaderInfo>(entity =>
            {
                entity.ToTable("HelloCashHeaderInfo", "aradashi");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("id");

                entity.Property(e => e.Description)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("description");

                entity.Property(e => e.LongTermToken).HasColumnName("long_term_token");

                entity.Property(e => e.Signature).HasColumnName("signature");
            });

            modelBuilder.Entity<MinimumGamePlayer>(entity =>
            {
                entity.ToTable("MinimumGamePlayer", "aradagame");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.GameType)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("game_type");

                entity.Property(e => e.MinPlayer).HasColumnName("min_player");

                entity.HasOne(d => d.GameTypeNavigation)
                    .WithMany(p => p.MinimumGamePlayers)
                    .HasForeignKey(d => d.GameType)
                    .HasConstraintName("FK_MinimumGamePlayer_GameType");
            });

            modelBuilder.Entity<MinimumTransactionAmount>(entity =>
            {
                entity.ToTable("MinimumTransactionAmount", "aradashi");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Amount)
                    .HasColumnType("money")
                    .HasColumnName("amount");

                entity.Property(e => e.Bank).HasColumnName("bank");

                entity.Property(e => e.TransactionType)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("transaction_type");

                entity.HasOne(d => d.BankNavigation)
                    .WithMany(p => p.MinimumTransactionAmounts)
                    .HasForeignKey(d => d.Bank)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK_MinimumTransactionAmount_Bank");
            });

            modelBuilder.Entity<OrderShippingAddress>(entity =>
            {
                entity.ToTable("OrderShippingAddress", "ago");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("id");

                entity.Property(e => e.Description)
                    .HasMaxLength(500)
                    .HasColumnName("description");

                entity.Property(e => e.OrderId).HasColumnName("order_id");

                entity.Property(e => e.RegistrationDate)
                    .HasColumnType("datetime")
                    .HasColumnName("registration_date");

                entity.Property(e => e.ShippingAddress)
                    .HasMaxLength(80)
                    .IsUnicode(false)
                    .HasColumnName("shipping_address");

                entity.HasOne(d => d.Order)
                    .WithMany(p => p.OrderShippingAddresses)
                    .HasForeignKey(d => d.OrderId)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK_OrderShippingAddress_GebeyaOrder");
            });

            modelBuilder.Entity<PlayerScore>(entity =>
            {
                entity.ToTable("PlayerScore", "aradagame");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.ClientId).HasColumnName("client_id");

                entity.Property(e => e.Highscore)
                    .HasColumnName("highscore")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.ModifiedDate)
                    .HasColumnType("datetime")
                    .HasColumnName("modified_date");

                entity.Property(e => e.Rank)
                    .HasMaxLength(50)
                    .HasColumnName("rank");

                entity.Property(e => e.Score)
                    .HasColumnName("score")
                    .HasDefaultValueSql("((0))");

                entity.HasOne(d => d.Client)
                    .WithMany(p => p.PlayerScores)
                    .HasForeignKey(d => d.ClientId)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK_PlayerScore_ClientInfo");
            });

            modelBuilder.Entity<Product>(entity =>
            {
                entity.ToTable("Product", "ago");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Color)
                    .HasMaxLength(50)
                    .HasColumnName("color");

                entity.Property(e => e.Description)
                    .HasMaxLength(500)
                    .HasColumnName("description");

                entity.Property(e => e.DescriptionEt)
                    .HasMaxLength(500)
                    .HasColumnName("description_et");

                entity.Property(e => e.IsVatIncluded)
                    .HasColumnName("is_vat_included")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(100)
                    .HasColumnName("name");

                entity.Property(e => e.NameEt)
                    .HasMaxLength(100)
                    .HasColumnName("name_et");

                entity.Property(e => e.Price)
                    .HasColumnType("money")
                    .HasColumnName("price");

                entity.Property(e => e.Qty).HasColumnName("qty");

                entity.Property(e => e.RegistrationDate)
                    .HasColumnType("datetime")
                    .HasColumnName("registration_date");

                entity.Property(e => e.SellerId).HasColumnName("seller_id");

                entity.Property(e => e.ShelfId).HasColumnName("shelf_id");

                entity.Property(e => e.Size).HasColumnName("size");

                entity.Property(e => e.Status)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("status")
                    .HasDefaultValueSql("('INACTIVE')");

                entity.HasOne(d => d.Seller)
                    .WithMany(p => p.Products)
                    .HasForeignKey(d => d.SellerId)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK_Product_ProductSeller");

                entity.HasOne(d => d.Shelf)
                    .WithMany(p => p.Products)
                    .HasForeignKey(d => d.ShelfId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Product_ProductChildCategory");

                entity.HasOne(d => d.SizeNavigation)
                    .WithMany(p => p.Products)
                    .HasForeignKey(d => d.Size)
                    .HasConstraintName("FK_Product_ProductSize");
            });

            modelBuilder.Entity<ProductAddress>(entity =>
            {
                entity.ToTable("ProductAddress", "ago");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.City)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("city");

                entity.Property(e => e.CityEt)
                    .HasMaxLength(50)
                    .HasColumnName("city_et");

                entity.Property(e => e.LocationDescription)
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasColumnName("location_description")
                    .HasDefaultValueSql("('N/A')");

                entity.Property(e => e.LocationDescriptionEt)
                    .HasMaxLength(500)
                    .HasColumnName("location_description_et")
                    .HasDefaultValueSql("('N/A')");

                entity.Property(e => e.MapLocation)
                    .HasMaxLength(80)
                    .IsUnicode(false)
                    .HasColumnName("map_location");

                entity.Property(e => e.Phone1)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("phone_1");

                entity.Property(e => e.Phone2)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("phone_2");

                entity.Property(e => e.ProductId).HasColumnName("product_id");

                entity.Property(e => e.ShopName)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("shop_name")
                    .HasDefaultValueSql("('N/A')");

                entity.Property(e => e.ShopNameEt)
                    .HasMaxLength(30)
                    .HasColumnName("shop_name_et")
                    .HasDefaultValueSql("('N/A')");

                entity.HasOne(d => d.Product)
                    .WithMany(p => p.ProductAddresses)
                    .HasForeignKey(d => d.ProductId)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK_ProductAddress_Product");
            });

            modelBuilder.Entity<ProductMedium>(entity =>
            {
                entity.ToTable("ProductMedia", "ago");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.FileAddress).HasColumnName("file_address");

                entity.Property(e => e.FileType)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("file_type");

                entity.Property(e => e.ProductId).HasColumnName("product_id");

                entity.HasOne(d => d.FileTypeNavigation)
                    .WithMany(p => p.ProductMedia)
                    .HasForeignKey(d => d.FileType)
                    .HasConstraintName("FK_ProductMedia_AttachmentType");

                entity.HasOne(d => d.Product)
                    .WithMany(p => p.ProductMedia)
                    .HasForeignKey(d => d.ProductId)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK_ProductMedia_Product");
            });

            modelBuilder.Entity<ProductOrder>(entity =>
            {
                entity.ToTable("ProductOrder", "ago");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.OrderDate)
                    .HasColumnType("datetime")
                    .HasColumnName("order_date");

                entity.Property(e => e.OrderId).HasColumnName("order_id");

                entity.Property(e => e.ProductId).HasColumnName("product_id");

                entity.Property(e => e.Qty).HasColumnName("qty");

                entity.Property(e => e.Status)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("status")
                    .HasDefaultValueSql("('ACTIVE')");

                entity.HasOne(d => d.Order)
                    .WithMany(p => p.ProductOrders)
                    .HasForeignKey(d => d.OrderId)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK_ProductOrder_GebeyaOrder");

                entity.HasOne(d => d.Product)
                    .WithMany(p => p.ProductOrders)
                    .HasForeignKey(d => d.ProductId)
                    .HasConstraintName("FK_ProductOrder_Product");
            });

            modelBuilder.Entity<ProductPaymentOption>(entity =>
            {
                entity.HasKey(e => e.Name);

                entity.ToTable("ProductPaymentOption", "ago");

                entity.Property(e => e.Name)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("name");

                entity.Property(e => e.Description)
                    .HasMaxLength(500)
                    .HasColumnName("description");
            });

            modelBuilder.Entity<ProductRating>(entity =>
            {
                entity.ToTable("ProductRating", "ago");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.ClientId).HasColumnName("client_id");

                entity.Property(e => e.ProductId).HasColumnName("product_id");

                entity.Property(e => e.Rating).HasColumnName("rating");

                entity.Property(e => e.RegistrationDate)
                    .HasColumnType("datetime")
                    .HasColumnName("registration_date");

                entity.HasOne(d => d.Client)
                    .WithMany(p => p.ProductRatings)
                    .HasForeignKey(d => d.ClientId)
                    .OnDelete(DeleteBehavior.SetNull)
                    .HasConstraintName("FK_ProductRating_ClientInfo");

                entity.HasOne(d => d.Product)
                    .WithMany(p => p.ProductRatings)
                    .HasForeignKey(d => d.ProductId)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK_ProductRating_Product");
            });

            modelBuilder.Entity<ProductSeller>(entity =>
            {
                entity.ToTable("ProductSeller", "ago");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.ClientId).HasColumnName("client_id");

                entity.Property(e => e.ContactPerson)
                    .HasMaxLength(50)
                    .HasColumnName("contact_person");

                entity.Property(e => e.ContactPhone)
                    .HasMaxLength(13)
                    .IsUnicode(false)
                    .HasColumnName("contact_phone");

                entity.Property(e => e.ModifiedDate)
                    .HasColumnType("datetime")
                    .HasColumnName("modified_date");

                entity.Property(e => e.Name)
                    .HasMaxLength(70)
                    .HasColumnName("name");

                entity.Property(e => e.RegistrationDate)
                    .HasColumnType("datetime")
                    .HasColumnName("registration_date");

                entity.Property(e => e.Status)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("status");

                entity.HasOne(d => d.Client)
                    .WithMany(p => p.ProductSellers)
                    .HasForeignKey(d => d.ClientId)
                    .OnDelete(DeleteBehavior.SetNull)
                    .HasConstraintName("FK_ProductSeller_ClientInfo");
            });

            modelBuilder.Entity<ProductSetting>(entity =>
            {
                entity.ToTable("ProductSetting", "ago");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.DeliveryFeePerKm)
                    .HasColumnType("money")
                    .HasColumnName("delivery_fee_per_km");

                entity.Property(e => e.IsDirectOrderAvailable)
                    .HasColumnName("is_direct_order_available")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.ModifiedDate)
                    .HasColumnType("datetime")
                    .HasColumnName("modified_date");

                entity.Property(e => e.PaymentOption)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("payment_option")
                    .HasDefaultValueSql("('N/A')");

                entity.Property(e => e.ProductId).HasColumnName("product_id");

                entity.Property(e => e.UpFrontFeePercent)
                    .HasColumnName("up_front_fee_percent")
                    .HasDefaultValueSql("((0))");

                entity.HasOne(d => d.PaymentOptionNavigation)
                    .WithMany(p => p.ProductSettings)
                    .HasForeignKey(d => d.PaymentOption)
                    .HasConstraintName("FK_ProductSetting_ProductPaymentOption");

                entity.HasOne(d => d.Product)
                    .WithMany(p => p.ProductSettings)
                    .HasForeignKey(d => d.ProductId)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK_ProductSetting_Product");
            });

            modelBuilder.Entity<ProductSize>(entity =>
            {
                entity.ToTable("ProductSize", "ago");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Description)
                    .HasMaxLength(50)
                    .HasColumnName("description");

                entity.Property(e => e.DescriptionEt)
                    .HasMaxLength(50)
                    .HasColumnName("description_et");

                entity.Property(e => e.SizeCategory)
                    .HasMaxLength(50)
                    .HasColumnName("size_category");
            });

            modelBuilder.Entity<ProductSizeCategory>(entity =>
            {
                entity.HasKey(e => e.Category);

                entity.ToTable("ProductSizeCategory", "ago");

                entity.Property(e => e.Category)
                    .HasMaxLength(50)
                    .HasColumnName("category")
                    .UseCollation("SQL_Latin1_General_CP437_BIN2");
            });

            modelBuilder.Entity<ProductTag>(entity =>
            {
                entity.ToTable("ProductTag", "ago");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.ProductId).HasColumnName("product_id");

                entity.Property(e => e.Tag)
                    .HasMaxLength(100)
                    .HasColumnName("tag");

                entity.HasOne(d => d.Product)
                    .WithMany(p => p.ProductTags)
                    .HasForeignKey(d => d.ProductId)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK_ProductTag_Product");
            });

            modelBuilder.Entity<Question>(entity =>
            {
                entity.ToTable("Question", "aradagame");

                entity.Property(e => e.Id)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("id")
                    .HasComment("Primary key of the table");

                entity.Property(e => e.AttachmentId).HasColumnName("attachment_id");

                entity.Property(e => e.AttachmentUrl).HasColumnName("attachment_url");

                entity.Property(e => e.Author)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("author");

                entity.Property(e => e.DifficultyLevel)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("difficulty_level")
                    .HasDefaultValueSql("('VERY EASY')")
                    .HasComment("Used to identify the question difficulty level");

                entity.Property(e => e.GenreId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("genre_id")
                    .HasComment("used to identify the question genre");

                entity.Property(e => e.Question1)
                    .HasMaxLength(4000)
                    .HasColumnName("question")
                    .HasComment("Used to identify the question");

                entity.Property(e => e.QuestionTypeId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("question_type_id");

                entity.Property(e => e.RegistrationDate)
                    .HasColumnType("datetime")
                    .HasColumnName("registration_date")
                    .HasComment("Used to identify the date that the question registered into the database");

                entity.Property(e => e.Source)
                    .HasMaxLength(1000)
                    .HasColumnName("source");

                entity.Property(e => e.Status)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("status")
                    .HasDefaultValueSql("('ACTIVE')")
                    .HasComment("Used to identify the status of the question");
            });

            modelBuilder.Entity<QuestionChoise>(entity =>
            {
                entity.ToTable("QuestionChoise", "aradagame");

                entity.HasComment("primary key of the table");

                entity.Property(e => e.Id)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("id");

                entity.Property(e => e.Answer)
                    .HasMaxLength(4000)
                    .HasColumnName("answer");

                entity.Property(e => e.IsAnswer)
                    .HasColumnName("is_answer")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.QuestionId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("question_id");

                entity.HasOne(d => d.Question)
                    .WithMany(p => p.QuestionChoises)
                    .HasForeignKey(d => d.QuestionId)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK_QuestionChoise_Question");
            });

            modelBuilder.Entity<QuestionDifficultyMode>(entity =>
            {
                entity.HasKey(e => e.Mode);

                entity.ToTable("QuestionDifficultyMode", "aradagame");

                entity.Property(e => e.Mode)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("mode");

                entity.Property(e => e.Description)
                    .HasMaxLength(500)
                    .HasColumnName("description");

                entity.Property(e => e.SuggestedUsage)
                    .HasMaxLength(500)
                    .HasColumnName("suggested_usage");
            });

            modelBuilder.Entity<QuestionType>(entity =>
            {
                entity.ToTable("QuestionType", "aradagame");

                entity.Property(e => e.Id)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("id");

                entity.Property(e => e.Status)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("status");

                entity.Property(e => e.Type)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("type");
            });

            modelBuilder.Entity<ServiceChargeRate>(entity =>
            {
                entity.ToTable("ServiceChargeRate", "aradashi");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Rate).HasColumnName("rate");

                entity.Property(e => e.Reason)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("reason");
            });

            modelBuilder.Entity<SessionLog>(entity =>
            {
                entity.ToTable("SessionLog", "aradashi");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.ClientId).HasColumnName("client_id");

                entity.Property(e => e.Duration)
                    .HasColumnType("decimal(18, 0)")
                    .HasColumnName("duration");

                entity.Property(e => e.EndedDate)
                    .HasColumnType("datetime")
                    .HasColumnName("ended_date");

                entity.Property(e => e.LogDate)
                    .HasColumnType("datetime")
                    .HasColumnName("log_date");

                entity.Property(e => e.StartedDate)
                    .HasColumnType("datetime")
                    .HasColumnName("started_date");

                entity.HasOne(d => d.Client)
                    .WithMany(p => p.SessionLogs)
                    .HasForeignKey(d => d.ClientId)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK_SessionLog_ClientInfo");
            });

            modelBuilder.Entity<Shelf>(entity =>
            {
                entity.ToTable("Shelf", "ago");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Name)
                    .HasMaxLength(50)
                    .HasColumnName("name");

                entity.Property(e => e.SouqId).HasColumnName("souq_id");

                entity.Property(e => e.Status)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("status");

                entity.HasOne(d => d.Souq)
                    .WithMany(p => p.Shelves)
                    .HasForeignKey(d => d.SouqId)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK_ProductChildCategory_ProductCategory");
            });

            modelBuilder.Entity<Souq>(entity =>
            {
                entity.ToTable("Souq", "ago");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.DescriptionEt)
                    .HasMaxLength(100)
                    .HasColumnName("description_et");

                entity.Property(e => e.Name)
                    .HasMaxLength(50)
                    .HasColumnName("name");

                entity.Property(e => e.Status)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("status");
            });

            modelBuilder.Entity<SouqServiceFeeLog>(entity =>
            {
                entity.ToTable("SouqServiceFeeLog", "ago");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.ClientId).HasColumnName("client_id");

                entity.Property(e => e.RegistrationDate)
                    .HasColumnType("datetime")
                    .HasColumnName("registration_date");

                entity.Property(e => e.ServiceFee)
                    .HasColumnType("money")
                    .HasColumnName("service_fee");

                entity.Property(e => e.SouqId).HasColumnName("souq_id");

                entity.HasOne(d => d.Client)
                    .WithMany(p => p.SouqServiceFeeLogs)
                    .HasForeignKey(d => d.ClientId)
                    .HasConstraintName("FK_SouqServiceFeeLog_ClientInfo");

                entity.HasOne(d => d.Souq)
                    .WithMany(p => p.SouqServiceFeeLogs)
                    .HasForeignKey(d => d.SouqId)
                    .HasConstraintName("FK_SouqServiceFeeLog_ProductCategory");
            });

            modelBuilder.Entity<SouqSetting>(entity =>
            {
                entity.ToTable("SouqSetting", "ago");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.ChildCategoryQuota).HasColumnName("child_category_quota");

                entity.Property(e => e.EnableServiceFee)
                    .HasColumnName("enable_service_fee")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.MaxItemPerOrder).HasColumnName("max_item_per_order");

                entity.Property(e => e.ModifiedDate)
                    .HasColumnType("datetime")
                    .HasColumnName("modified_date");

                entity.Property(e => e.ProductPostingQuota).HasColumnName("product_posting_quota");

                entity.Property(e => e.SellerId).HasColumnName("seller_id");

                entity.Property(e => e.ServiceFee)
                    .HasColumnType("money")
                    .HasColumnName("service_fee")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.SouqId).HasColumnName("souq_id");

                entity.HasOne(d => d.Seller)
                    .WithMany(p => p.SouqSettings)
                    .HasForeignKey(d => d.SellerId)
                    .HasConstraintName("FK_SellerSetting_ProductSeller");

                entity.HasOne(d => d.Souq)
                    .WithMany(p => p.SouqSettings)
                    .HasForeignKey(d => d.SouqId)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK_SouqSetting_ProductCategory");
            });

            modelBuilder.Entity<SponsoredGameInfo>(entity =>
            {
                entity.ToTable("SponsoredGameInfo", "aradagame");

                entity.HasComment("Sponsored amount for individual player");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.ExpiryDate)
                    .HasColumnType("datetime")
                    .HasColumnName("expiry_date");

                entity.Property(e => e.GameSettingId).HasColumnName("game_setting_id");

                entity.Property(e => e.RegistrationDate)
                    .HasColumnType("datetime")
                    .HasColumnName("registration_date");

                entity.Property(e => e.SponsorId).HasColumnName("sponsor_id");

                entity.Property(e => e.SponsoredAmount)
                    .HasColumnType("money")
                    .HasColumnName("sponsored_amount");

                entity.Property(e => e.StartingDate)
                    .HasColumnType("datetime")
                    .HasColumnName("starting_date");

                entity.Property(e => e.Status)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("status");

                entity.HasOne(d => d.GameSetting)
                    .WithMany(p => p.SponsoredGameInfos)
                    .HasForeignKey(d => d.GameSettingId)
                    .OnDelete(DeleteBehavior.SetNull)
                    .HasConstraintName("FK_SponsoredGameInfo_GameSetting");

                entity.HasOne(d => d.Sponsor)
                    .WithMany(p => p.SponsoredGameInfos)
                    .HasForeignKey(d => d.SponsorId)
                    .OnDelete(DeleteBehavior.SetNull)
                    .HasConstraintName("FK_SponsoredGameInfo_GameSponserInfo");
            });

            modelBuilder.Entity<StickerRepo>(entity =>
            {
                entity.ToTable("StickerRepo", "aradashi");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.AttachmentId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("attachment_id");

                entity.Property(e => e.Message).HasColumnName("message");

                entity.Property(e => e.MessageType)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("message_type");

                entity.Property(e => e.RegistrationDate)
                    .HasColumnType("datetime")
                    .HasColumnName("registration_date");

                entity.Property(e => e.Type)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("type");
            });

            modelBuilder.Entity<ViewAccountBalance>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("ViewAccountBalance", "aradashi");

                entity.Property(e => e.Balance)
                    .HasColumnType("money")
                    .HasColumnName("balance");

                entity.Property(e => e.Phone)
                    .HasMaxLength(18)
                    .IsUnicode(false)
                    .HasColumnName("phone");

                entity.Property(e => e.TelegramId)
                    .IsRequired()
                    .HasMaxLength(60)
                    .IsUnicode(false)
                    .HasColumnName("telegram_id");
            });

            modelBuilder.Entity<ViewAdvertisement>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("ViewAdvertisement", "ad");

                entity.Property(e => e.AdvertType)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("advert_type");

                entity.Property(e => e.Advertisement).HasColumnName("advertisement");

                entity.Property(e => e.AgeGroup)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("age_group");

                entity.Property(e => e.Company)
                    .HasMaxLength(500)
                    .HasColumnName("company");

                entity.Property(e => e.Duration).HasColumnName("duration");

                entity.Property(e => e.EndedDate)
                    .HasColumnType("datetime")
                    .HasColumnName("ended_date");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.PhotoUrl).HasColumnName("photo_url");

                entity.Property(e => e.PopupOption)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("popup_option");

                entity.Property(e => e.RegistrationDate)
                    .HasColumnType("datetime")
                    .HasColumnName("registration_date");

                entity.Property(e => e.Schedule)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("schedule");

                entity.Property(e => e.Sitemap).HasColumnName("sitemap");

                entity.Property(e => e.StartingDate)
                    .HasColumnType("datetime")
                    .HasColumnName("starting_date");

                entity.Property(e => e.Status)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("status");
            });

            modelBuilder.Entity<ViewAdvertisementPage>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("ViewAdvertisementPage", "ad");

                entity.Property(e => e.Id)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("id");

                entity.Property(e => e.Sitemap).HasColumnName("sitemap");

                entity.Property(e => e.Status)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("status");
            });

            modelBuilder.Entity<ViewAmoleHeaderInfo>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("ViewAmoleHeaderInfo", "aradashi");

                entity.Property(e => e.Id)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("id");

                entity.Property(e => e.Ip)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("ip");

                entity.Property(e => e.Passwd)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("passwd");

                entity.Property(e => e.Signature)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("signature");

                entity.Property(e => e.Username)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("username");
            });

            modelBuilder.Entity<ViewAnimatedSticker>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("ViewAnimatedSticker", "aradashi");

                entity.Property(e => e.Id)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("id");

                entity.Property(e => e.Message).HasColumnName("message");

                entity.Property(e => e.MessageType)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("message_type");

                entity.Property(e => e.Type)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("type");
            });

            modelBuilder.Entity<ViewCard>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("ViewCard", "ago");

                entity.Property(e => e.CardAmount).HasColumnName("card_amount");

                entity.Property(e => e.ExpiryDate)
                    .HasColumnType("datetime")
                    .HasColumnName("expiry_date");

                entity.Property(e => e.Id)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("id");

                entity.Property(e => e.RegistrationDate)
                    .HasColumnType("datetime")
                    .HasColumnName("registration_date");

                entity.Property(e => e.SerialNumber)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("serial_number");

                entity.Property(e => e.Status)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("status");

                entity.Property(e => e.SupplierName)
                    .HasMaxLength(50)
                    .HasColumnName("supplier_name");

                entity.Property(e => e.Telecom)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("telecom");

                entity.Property(e => e.VoucherPin)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("voucher_pin");
            });

            modelBuilder.Entity<ViewCardProvider>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("ViewCardProviders", "ago");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("name");

                entity.Property(e => e.Status)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("status");
            });

            modelBuilder.Entity<ViewClientAccount>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("ViewClientAccount", "aradashi");

                entity.Property(e => e.Balance)
                    .HasColumnType("money")
                    .HasColumnName("balance");

                entity.Property(e => e.ClientId).HasColumnName("client_id");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.ModifiedDate)
                    .HasColumnType("datetime")
                    .HasColumnName("modified_date");

                entity.Property(e => e.RegistrationDate)
                    .HasColumnType("datetime")
                    .HasColumnName("registration_date");

                entity.Property(e => e.TelegramId)
                    .IsRequired()
                    .HasMaxLength(60)
                    .IsUnicode(false)
                    .HasColumnName("telegram_id");
            });

            modelBuilder.Entity<ViewClientGame>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("ViewClientGames", "aradagame");

                entity.Property(e => e.Creator).HasColumnName("creator");

                entity.Property(e => e.GameFee)
                    .HasColumnType("money")
                    .HasColumnName("game_fee");

                entity.Property(e => e.GameGenre)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("game_genre");

                entity.Property(e => e.GameSchedule)
                    .HasColumnType("datetime")
                    .HasColumnName("game_schedule");

                entity.Property(e => e.GameScheduleEt)
                    .HasMaxLength(50)
                    .HasColumnName("game_schedule_et");

                entity.Property(e => e.Genre)
                    .HasMaxLength(50)
                    .HasColumnName("genre");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Status)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("status");

                entity.Property(e => e.TelegramId)
                    .IsRequired()
                    .HasMaxLength(60)
                    .IsUnicode(false)
                    .HasColumnName("telegram_id");

                entity.Property(e => e.Type)
                    .HasMaxLength(50)
                    .HasColumnName("type");
            });

            modelBuilder.Entity<ViewClientGameFee>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("ViewClientGameFee", "aradagame");

                entity.Property(e => e.ClientAccount).HasColumnName("client_account");

                entity.Property(e => e.ClientId).HasColumnName("client_id");

                entity.Property(e => e.RefNumber)
                    .IsUnicode(false)
                    .HasColumnName("ref_number");

                entity.Property(e => e.WithdrawalDate)
                    .HasColumnType("datetime")
                    .HasColumnName("withdrawal_date");

                entity.Property(e => e.WithdrawalId).HasColumnName("withdrawal_id");

                entity.Property(e => e.WithdrawalReason)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("withdrawal_reason");
            });

            modelBuilder.Entity<ViewClientId>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("ViewClientId", "aradashi");

                entity.Property(e => e.Id)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("id");

                entity.Property(e => e.Phone)
                    .HasMaxLength(18)
                    .IsUnicode(false)
                    .HasColumnName("phone");

                entity.Property(e => e.TelegramId)
                    .IsRequired()
                    .HasMaxLength(60)
                    .IsUnicode(false)
                    .HasColumnName("telegram_id");
            });

            modelBuilder.Entity<ViewClientInfo>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("ViewClientInfo", "aradashi");

                entity.Property(e => e.Firstname)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("firstname");

                entity.Property(e => e.Id)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("id");

                entity.Property(e => e.Lastname)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("lastname");

                entity.Property(e => e.Phone)
                    .HasMaxLength(18)
                    .IsUnicode(false)
                    .HasColumnName("phone");

                entity.Property(e => e.TelegramId)
                    .IsRequired()
                    .HasMaxLength(60)
                    .IsUnicode(false)
                    .HasColumnName("telegram_id");

                entity.Property(e => e.Username)
                    .HasMaxLength(40)
                    .HasColumnName("username");
            });

            modelBuilder.Entity<ViewDeposit>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("ViewDeposit", "aradashi");

                entity.Property(e => e.Amount)
                    .HasColumnType("money")
                    .HasColumnName("amount");

                entity.Property(e => e.BankId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("bank_id");

                entity.Property(e => e.ClientAccountId).HasColumnName("client_account_id");

                entity.Property(e => e.DepositDate)
                    .HasColumnType("datetime")
                    .HasColumnName("deposit_date");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.InvoiceNumber)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("invoice_number");

                entity.Property(e => e.PaymentMethod)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("payment_method");

                entity.Property(e => e.Status)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("status");

                entity.Property(e => e.TtNumber)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("tt_number");
            });

            modelBuilder.Entity<ViewGame>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("ViewGame", "aradagame");

                entity.Property(e => e.Creator).HasColumnName("creator");

                entity.Property(e => e.EndingDate)
                    .HasColumnType("datetime")
                    .HasColumnName("ending_date");

                entity.Property(e => e.GameFee)
                    .HasColumnType("money")
                    .HasColumnName("game_fee");

                entity.Property(e => e.GameSchedule)
                    .HasColumnType("datetime")
                    .HasColumnName("game_schedule");

                entity.Property(e => e.GameScheduleEt)
                    .HasMaxLength(50)
                    .HasColumnName("game_schedule_et");

                entity.Property(e => e.Genre)
                    .HasMaxLength(50)
                    .HasColumnName("genre");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.IsNumberOfQuestionCustom).HasColumnName("is_number_of_question_custom");

                entity.Property(e => e.RegistrationDate)
                    .HasColumnType("datetime")
                    .HasColumnName("registration_date");

                entity.Property(e => e.StartingDate)
                    .HasColumnType("datetime")
                    .HasColumnName("starting_date");

                entity.Property(e => e.Status)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("status");

                entity.Property(e => e.TotalQuestions).HasColumnName("total_questions");

                entity.Property(e => e.Type)
                    .HasMaxLength(50)
                    .HasColumnName("type");
            });

            modelBuilder.Entity<ViewGameAdmissionFee>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("ViewGameAdmissionFee", "aradagame");

                entity.Property(e => e.Fee)
                    .HasColumnType("money")
                    .HasColumnName("fee");

                entity.Property(e => e.GameGenreId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("game_genre_id");

                entity.Property(e => e.Genre)
                    .HasMaxLength(50)
                    .HasColumnName("genre");

                entity.Property(e => e.Id).HasColumnName("id");
            });

            modelBuilder.Entity<ViewGameGenre>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("ViewGameGenre", "aradagame");

                entity.Property(e => e.Genre)
                    .HasMaxLength(50)
                    .HasColumnName("genre");

                entity.Property(e => e.Id)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("id");

                entity.Property(e => e.Status)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("status");
            });

            modelBuilder.Entity<ViewGamePlayer>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("ViewGamePlayers", "aradagame");

                entity.Property(e => e.Creator).HasColumnName("creator");

                entity.Property(e => e.EndedDate)
                    .HasColumnType("datetime")
                    .HasColumnName("ended_date");

                entity.Property(e => e.Firstname)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("firstname");

                entity.Property(e => e.GameFee)
                    .HasColumnType("money")
                    .HasColumnName("game_fee");

                entity.Property(e => e.GameGenre)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("game_genre");

                entity.Property(e => e.GameId).HasColumnName("game_id");

                entity.Property(e => e.GameSchedule)
                    .HasColumnType("datetime")
                    .HasColumnName("game_schedule");

                entity.Property(e => e.GameScheduleEt)
                    .HasMaxLength(50)
                    .HasColumnName("game_schedule_et");

                entity.Property(e => e.GameStatus)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("game_status");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.IsHagerUsed).HasColumnName("is_hager_used");

                entity.Property(e => e.IsQuestionAnswered).HasColumnName("is_question_answered");

                entity.Property(e => e.LastQuestion)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("last_question");

                entity.Property(e => e.LastQuestionNumber).HasColumnName("last_question_number");

                entity.Property(e => e.MinPlayer).HasColumnName("min_player");

                entity.Property(e => e.PlayerId).HasColumnName("player_id");

                entity.Property(e => e.Status)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("status");

                entity.Property(e => e.TelegramId)
                    .IsRequired()
                    .HasMaxLength(60)
                    .IsUnicode(false)
                    .HasColumnName("telegram_id");

                entity.Property(e => e.Type)
                    .HasMaxLength(50)
                    .HasColumnName("type");
            });

            modelBuilder.Entity<ViewGameSetting>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("ViewGameSetting", "aradagame");

                entity.Property(e => e.DifficultyLevel)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("difficulty_level");

                entity.Property(e => e.Genre)
                    .HasMaxLength(50)
                    .HasColumnName("genre");

                entity.Property(e => e.GenreId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("genre_id");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.IsSponsored).HasColumnName("is_sponsored");

                entity.Property(e => e.MaxPlayer).HasColumnName("max_player");
            });

            modelBuilder.Entity<ViewGameSponserInfo>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("ViewGameSponserInfo", "aradagame");

                entity.Property(e => e.ClientId).HasColumnName("client_id");

                entity.Property(e => e.ContactNumber)
                    .HasMaxLength(13)
                    .IsUnicode(false)
                    .HasColumnName("contact_number");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Name)
                    .HasMaxLength(100)
                    .HasColumnName("name");

                entity.Property(e => e.RegistrationDate)
                    .HasColumnType("datetime")
                    .HasColumnName("registration_date");

                entity.Property(e => e.Status)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("status");

                entity.Property(e => e.TelegramId)
                    .IsRequired()
                    .HasMaxLength(60)
                    .IsUnicode(false)
                    .HasColumnName("telegram_id");

                entity.Property(e => e.Tin)
                    .HasMaxLength(50)
                    .HasColumnName("tin");
            });

            modelBuilder.Entity<ViewGameStatus>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("ViewGameStatus", "aradagame");

                entity.Property(e => e.GameSchedule)
                    .HasColumnType("datetime")
                    .HasColumnName("game_schedule");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Status)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("status");

                entity.Property(e => e.Type)
                    .HasMaxLength(50)
                    .HasColumnName("type");
            });

            modelBuilder.Entity<ViewGameType>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("ViewGameType", "aradagame");

                entity.Property(e => e.Id)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("id");

                entity.Property(e => e.Type)
                    .HasMaxLength(50)
                    .HasColumnName("type");
            });

            modelBuilder.Entity<ViewGameplayAlgorithm>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("ViewGameplayAlgorithm", "aradagame");

                entity.Property(e => e.DifficultyMode)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("difficulty_mode");

                entity.Property(e => e.EasyQuestionPercent)
                    .HasColumnType("decimal(18, 0)")
                    .HasColumnName("easy_question_percent");

                entity.Property(e => e.Genre)
                    .HasMaxLength(50)
                    .HasColumnName("genre");

                entity.Property(e => e.HardQuestionPercent)
                    .HasColumnType("decimal(18, 0)")
                    .HasColumnName("hard_question_percent");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.RegistrationDate)
                    .HasColumnType("datetime")
                    .HasColumnName("registration_date");

                entity.Property(e => e.Status)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("status");

                entity.Property(e => e.VeryEasyQuestionPercent)
                    .HasColumnType("decimal(18, 0)")
                    .HasColumnName("very_easy_question_percent");

                entity.Property(e => e.VeryHardQuestionPercent)
                    .HasColumnType("decimal(18, 0)")
                    .HasColumnName("very_hard_question_percent");
            });

            modelBuilder.Entity<ViewGiftLog>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("ViewGiftLog", "aradashi");

                entity.Property(e => e.ClientId).HasColumnName("client_id");

                entity.Property(e => e.GiftId).HasColumnName("gift_id");

                entity.Property(e => e.GiftMode)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("gift_mode");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.RegistrationDate)
                    .HasColumnType("datetime")
                    .HasColumnName("registration_date");

                entity.Property(e => e.Status)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("status");
            });

            modelBuilder.Entity<ViewHager>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("ViewHager", "ago");

                entity.Property(e => e.Description)
                    .HasMaxLength(100)
                    .HasColumnName("description");

                entity.Property(e => e.Id)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("id");

                entity.Property(e => e.Name)
                    .HasMaxLength(30)
                    .HasColumnName("name");

                entity.Property(e => e.Price)
                    .HasColumnType("money")
                    .HasColumnName("price");

                entity.Property(e => e.ProductCategoryId).HasColumnName("product_category_id");

                entity.Property(e => e.Qty).HasColumnName("qty");

                entity.Property(e => e.RegistrationDate)
                    .HasColumnType("datetime")
                    .HasColumnName("registration_date");

                entity.Property(e => e.Status)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("status");
            });

            modelBuilder.Entity<ViewHelloCashHeaderInfo>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("ViewHelloCashHeaderInfo", "aradashi");

                entity.Property(e => e.Description)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("description");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Signature).HasColumnName("signature");
            });

            modelBuilder.Entity<ViewLeaderboard>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("ViewLeaderboard", "aradagame");

                entity.Property(e => e.Highscore).HasColumnName("highscore");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.PlayerName)
                    .IsRequired()
                    .HasMaxLength(101)
                    .HasColumnName("player_name");
            });

            modelBuilder.Entity<ViewMinTransactionAmount>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("ViewMinTransactionAmount", "aradashi");

                entity.Property(e => e.Amount)
                    .HasColumnType("money")
                    .HasColumnName("amount");

                entity.Property(e => e.Bank)
                    .HasMaxLength(100)
                    .HasColumnName("bank");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.TransactionType)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("transaction_type");
            });

            modelBuilder.Entity<ViewMinimumPlayer>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("ViewMinimumPlayer", "aradagame");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.MinPlayer).HasColumnName("min_player");

                entity.Property(e => e.Type)
                    .HasMaxLength(50)
                    .HasColumnName("type");
            });

            modelBuilder.Entity<ViewPlayerScore>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("ViewPlayerScore", "aradagame");

                entity.Property(e => e.ClientId).HasColumnName("client_id");

                entity.Property(e => e.Highscore).HasColumnName("highscore");

                entity.Property(e => e.Id)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("id");

                entity.Property(e => e.ModifiedDate)
                    .HasColumnType("datetime")
                    .HasColumnName("modified_date");

                entity.Property(e => e.Rank)
                    .HasMaxLength(50)
                    .HasColumnName("rank");

                entity.Property(e => e.Score).HasColumnName("score");
            });

            modelBuilder.Entity<ViewProduct>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("ViewProduct", "ago");

                entity.Property(e => e.Color)
                    .HasMaxLength(50)
                    .HasColumnName("color");

                entity.Property(e => e.Description)
                    .HasMaxLength(500)
                    .HasColumnName("description");

                entity.Property(e => e.DescriptionEt)
                    .HasMaxLength(500)
                    .HasColumnName("description_et");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.IsVatIncluded).HasColumnName("is_vat_included");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(100)
                    .HasColumnName("name");

                entity.Property(e => e.NameEt)
                    .HasMaxLength(100)
                    .HasColumnName("name_et");

                entity.Property(e => e.Price)
                    .HasColumnType("money")
                    .HasColumnName("price");

                entity.Property(e => e.Qty).HasColumnName("qty");

                entity.Property(e => e.RegistrationDate)
                    .HasColumnType("datetime")
                    .HasColumnName("registration_date");

                entity.Property(e => e.Seller)
                    .HasMaxLength(70)
                    .HasColumnName("seller");

                entity.Property(e => e.SellerId).HasColumnName("seller_id");

                entity.Property(e => e.ShelfId).HasColumnName("shelf_id");

                entity.Property(e => e.Size)
                    .HasMaxLength(50)
                    .HasColumnName("size");

                entity.Property(e => e.SizeEt)
                    .HasMaxLength(50)
                    .HasColumnName("size_et");

                entity.Property(e => e.SouqId).HasColumnName("souq_id");

                entity.Property(e => e.Status)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("status");
            });

            modelBuilder.Entity<ViewProductAddress>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("ViewProductAddress", "ago");

                entity.Property(e => e.City)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("city");

                entity.Property(e => e.CityEt)
                    .HasMaxLength(50)
                    .HasColumnName("city_et");

                entity.Property(e => e.Id)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("id");

                entity.Property(e => e.LocationDescription)
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasColumnName("location_description");

                entity.Property(e => e.LocationDescriptionEt)
                    .HasMaxLength(500)
                    .HasColumnName("location_description_et");

                entity.Property(e => e.MapLocation)
                    .HasMaxLength(80)
                    .IsUnicode(false)
                    .HasColumnName("map_location");

                entity.Property(e => e.Phone1)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("phone_1");

                entity.Property(e => e.Phone2)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("phone_2");

                entity.Property(e => e.ProductId).HasColumnName("product_id");

                entity.Property(e => e.ShopName)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("shop_name");

                entity.Property(e => e.ShopNameEt)
                    .HasMaxLength(30)
                    .HasColumnName("shop_name_et");
            });

            modelBuilder.Entity<ViewProductMedium>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("ViewProductMedia", "ago");

                entity.Property(e => e.FileAddress).HasColumnName("file_address");

                entity.Property(e => e.FileType)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("file_type");

                entity.Property(e => e.ProductId).HasColumnName("product_id");
            });

            modelBuilder.Entity<ViewProductRating>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("ViewProductRating", "ago");

                entity.Property(e => e.ClientId).HasColumnName("client_id");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.ProductId).HasColumnName("product_id");

                entity.Property(e => e.Rating).HasColumnName("rating");

                entity.Property(e => e.RegistrationDate)
                    .HasColumnType("datetime")
                    .HasColumnName("registration_date");

                entity.Property(e => e.SouqId).HasColumnName("souqId");
            });

            modelBuilder.Entity<ViewProductSetting>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("ViewProductSetting", "ago");

                entity.Property(e => e.DeliveryFeePerKm)
                    .HasColumnType("money")
                    .HasColumnName("delivery_fee_per_km");

                entity.Property(e => e.Description)
                    .HasMaxLength(500)
                    .HasColumnName("description");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.IsDirectOrderAvailable).HasColumnName("is_direct_order_available");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("name");

                entity.Property(e => e.ProductId).HasColumnName("product_id");

                entity.Property(e => e.UpFrontFeePercent).HasColumnName("up_front_fee_percent");
            });

            modelBuilder.Entity<ViewProductTag>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("ViewProductTag", "ago");

                entity.Property(e => e.Id)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("id");

                entity.Property(e => e.ProductId).HasColumnName("product_id");

                entity.Property(e => e.Tag)
                    .HasMaxLength(100)
                    .HasColumnName("tag");
            });

            modelBuilder.Entity<ViewQuestion>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("ViewQuestion", "aradagame");

                entity.Property(e => e.AttachmentUrl).HasColumnName("attachment_url");

                entity.Property(e => e.Author)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("author");

                entity.Property(e => e.DifficultyLevel)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("difficulty_level");

                entity.Property(e => e.Genre)
                    .HasMaxLength(50)
                    .HasColumnName("genre");

                entity.Property(e => e.Id)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("id");

                entity.Property(e => e.Question)
                    .HasMaxLength(4000)
                    .HasColumnName("question");

                entity.Property(e => e.QuestionTypeId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("question_type_id");

                entity.Property(e => e.RegistrationDate)
                    .HasColumnType("datetime")
                    .HasColumnName("registration_date");

                entity.Property(e => e.Status)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("status");
            });

            modelBuilder.Entity<ViewQuestionChooise>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("ViewQuestionChooise", "aradagame");

                entity.Property(e => e.Answer)
                    .HasMaxLength(4000)
                    .HasColumnName("answer");

                entity.Property(e => e.Id)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("id");

                entity.Property(e => e.IsAnswer).HasColumnName("is_answer");

                entity.Property(e => e.QuestionId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("question_id");
            });

            modelBuilder.Entity<ViewServiceChargeRate>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("ViewServiceChargeRate", "aradashi");

                entity.Property(e => e.Id)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("id");

                entity.Property(e => e.Rate).HasColumnName("rate");

                entity.Property(e => e.Reason)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("reason");
            });

            modelBuilder.Entity<ViewShelf>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("ViewShelf", "ago");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Souq)
                    .HasMaxLength(50)
                    .HasColumnName("souq");

                entity.Property(e => e.SouqId).HasColumnName("souq_id");

                entity.Property(e => e.Status)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("status");
            });

            modelBuilder.Entity<ViewSouqSetting>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("ViewSouqSetting", "ago");

                entity.Property(e => e.ChildCategoryQuota).HasColumnName("child_category_quota");

                entity.Property(e => e.EnableServiceFee).HasColumnName("enable_service_fee");

                entity.Property(e => e.Id)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("id");

                entity.Property(e => e.MaxItemPerOrder).HasColumnName("max_item_per_order");

                entity.Property(e => e.ProductPostingQuota).HasColumnName("product_posting_quota");

                entity.Property(e => e.SellerId).HasColumnName("seller_id");

                entity.Property(e => e.ServiceFee)
                    .HasColumnType("money")
                    .HasColumnName("service_fee");

                entity.Property(e => e.SouqId).HasColumnName("souq_id");
            });

            modelBuilder.Entity<ViewSponsoredGameInfo>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("ViewSponsoredGameInfo", "aradagame");

                entity.Property(e => e.ExpiryDate)
                    .HasColumnType("datetime")
                    .HasColumnName("expiry_date");

                entity.Property(e => e.GameSettingId).HasColumnName("game_setting_id");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.RegistrationDate)
                    .HasColumnType("datetime")
                    .HasColumnName("registration_date");

                entity.Property(e => e.SponsorId).HasColumnName("sponsor_id");

                entity.Property(e => e.SponsoredAmount)
                    .HasColumnType("money")
                    .HasColumnName("sponsored_amount");

                entity.Property(e => e.StartingDate)
                    .HasColumnType("datetime")
                    .HasColumnName("starting_date");

                entity.Property(e => e.Status)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("status");
            });

            modelBuilder.Entity<ViewUsersHager>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("ViewUsersHager", "ago");

                entity.Property(e => e.Available).HasColumnName("available");

                entity.Property(e => e.ClientId).HasColumnName("client_id");

                entity.Property(e => e.Id)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("id");

                entity.Property(e => e.ModifiedDate)
                    .HasColumnType("datetime")
                    .HasColumnName("modified_date");

                entity.Property(e => e.RegistrationDate)
                    .HasColumnType("datetime")
                    .HasColumnName("registration_date");
            });

            modelBuilder.Entity<ViewWithdrawal>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("ViewWithdrawal", "aradashi");

                entity.Property(e => e.Amount)
                    .HasColumnType("money")
                    .HasColumnName("amount");

                entity.Property(e => e.ClientAccountId).HasColumnName("client_account_id");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.InvoiceNumber)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("invoice_number");

                entity.Property(e => e.Reason)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("reason");

                entity.Property(e => e.RefNumber)
                    .IsUnicode(false)
                    .HasColumnName("ref_number");

                entity.Property(e => e.Status)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("status");

                entity.Property(e => e.WithdrawalDate)
                    .HasColumnType("datetime")
                    .HasColumnName("withdrawal_date");
            });

            modelBuilder.Entity<ViwProductAddress>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("ViwProductAddress", "ago");

                entity.Property(e => e.City)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("city");

                entity.Property(e => e.CityEt)
                    .HasMaxLength(50)
                    .HasColumnName("city_et");

                entity.Property(e => e.Id)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("id");

                entity.Property(e => e.LocationDescription)
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasColumnName("location_description");

                entity.Property(e => e.LocationDescriptionEt)
                    .HasMaxLength(500)
                    .HasColumnName("location_description_et");

                entity.Property(e => e.MapLocation)
                    .HasMaxLength(80)
                    .IsUnicode(false)
                    .HasColumnName("map_location");

                entity.Property(e => e.Phone1)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("phone_1");

                entity.Property(e => e.Phone2)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("phone_2");

                entity.Property(e => e.ProductId).HasColumnName("product_id");
            });

            modelBuilder.Entity<Withdrawal>(entity =>
            {
                entity.ToTable("Withdrawal", "aradashi");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Amount)
                    .HasColumnType("money")
                    .HasColumnName("amount");

                entity.Property(e => e.ClientAccountId).HasColumnName("client_account_id");

                entity.Property(e => e.ConfNumber).HasColumnName("conf_number");

                entity.Property(e => e.Reason)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("reason");

                entity.Property(e => e.RefNumber)
                    .IsUnicode(false)
                    .HasColumnName("ref_number");

                entity.Property(e => e.Status)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("status")
                    .HasDefaultValueSql("('REQUESTED')");

                entity.Property(e => e.WithdrawalDate)
                    .HasColumnType("datetime")
                    .HasColumnName("withdrawal_date");

                entity.HasOne(d => d.ClientAccount)
                    .WithMany(p => p.Withdrawals)
                    .HasForeignKey(d => d.ClientAccountId)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK_Withdrawal_ClientAccount");
            });

            modelBuilder.Entity<WithdrawalInvoice>(entity =>
            {
                entity.ToTable("WithdrawalInvoice", "aradashi");

                entity.HasIndex(e => e.InvoiceNumber, "UK_WithdrawalInvoice")
                    .IsUnique();

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.InvoiceNumber)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("invoice_number");

                entity.Property(e => e.RegistrationDate)
                    .HasColumnType("datetime")
                    .HasColumnName("registration_date");

                entity.Property(e => e.Status)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("status")
                    .HasDefaultValueSql("('INACTIVE')");

                entity.Property(e => e.WithdrawalId).HasColumnName("withdrawal_id");

                entity.HasOne(d => d.Withdrawal)
                    .WithMany(p => p.WithdrawalInvoices)
                    .HasForeignKey(d => d.WithdrawalId)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK_WithdrawalInvoice_Withdrawal");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
