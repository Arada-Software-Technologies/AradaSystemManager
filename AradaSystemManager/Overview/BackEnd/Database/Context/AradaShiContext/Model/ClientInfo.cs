using System;
using System.Collections.Generic;

#nullable disable

namespace AradaSystemManager.Overview.BackEnd.Database.Context.AradaShiContext.Model
{
    public partial class ClientInfo
    {
        public ClientInfo()
        {
            AmoleAccountInfos = new HashSet<AmoleAccountInfo>();
            ClientAccounts = new HashSet<ClientAccount>();
            ClientAddresses = new HashSet<ClientAddress>();
            ClientHagers = new HashSet<ClientHager>();
            GamePlayers = new HashSet<GamePlayer>();
            GameSponserInfos = new HashSet<GameSponserInfo>();
            Games = new HashSet<Game>();
            GebeyaOrders = new HashSet<GebeyaOrder>();
            GiftLogs = new HashSet<GiftLog>();
            PlayerScores = new HashSet<PlayerScore>();
            ProductRatings = new HashSet<ProductRating>();
            ProductSellers = new HashSet<ProductSeller>();
            SessionLogs = new HashSet<SessionLog>();
            SouqServiceFeeLogs = new HashSet<SouqServiceFeeLog>();
        }

        public long Id { get; set; }
        public string TelegramId { get; set; }
        public string Username { get; set; }
        public string Phone { get; set; }
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public string Status { get; set; }
        public string AgeGroup { get; set; }
        public DateTime? RegistrationDate { get; set; }
        public DateTime? LastActivityDate { get; set; }

        public virtual AdvertisementAgeGroup AgeGroupNavigation { get; set; }
        public virtual ICollection<AmoleAccountInfo> AmoleAccountInfos { get; set; }
        public virtual ICollection<ClientAccount> ClientAccounts { get; set; }
        public virtual ICollection<ClientAddress> ClientAddresses { get; set; }
        public virtual ICollection<ClientHager> ClientHagers { get; set; }
        public virtual ICollection<GamePlayer> GamePlayers { get; set; }
        public virtual ICollection<GameSponserInfo> GameSponserInfos { get; set; }
        public virtual ICollection<Game> Games { get; set; }
        public virtual ICollection<GebeyaOrder> GebeyaOrders { get; set; }
        public virtual ICollection<GiftLog> GiftLogs { get; set; }
        public virtual ICollection<PlayerScore> PlayerScores { get; set; }
        public virtual ICollection<ProductRating> ProductRatings { get; set; }
        public virtual ICollection<ProductSeller> ProductSellers { get; set; }
        public virtual ICollection<SessionLog> SessionLogs { get; set; }
        public virtual ICollection<SouqServiceFeeLog> SouqServiceFeeLogs { get; set; }
    }
}
