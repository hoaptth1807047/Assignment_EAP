using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Assignment_EAP.Models
{
    public class Coin
    {
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string BaseAsset { get; set; }
        [Required]
        public string QuoteAsset { get; set; }
        public int LastPrice { get; set; }
        public double Volumn24h { get; set; }
        public int MarketId { get; set; }
        public virtual Market Market { get; set; }
        public DateTime? CreateAt { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public int Status { get; set; }
    }
}