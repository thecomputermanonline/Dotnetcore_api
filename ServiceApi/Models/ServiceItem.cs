using System;
namespace ServiceApi.Models
{
    public class ServiceItem
    {
        public long Id { get; set; }
        public string SiteName { get; set; }
        public string Description { get; set; }
        public string ItPromoCode { get; set; }
        public bool BonusActivated { get; set; }
    }
}
