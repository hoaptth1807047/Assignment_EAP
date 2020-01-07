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
        [DisplayFormat(DataFormatString = "{0:N0}", ApplyFormatInEditMode = true)]
        public int LastPrice { get; set; }
        [DisplayFormat(DataFormatString = "{0:N0}", ApplyFormatInEditMode = true)]
        public double Volumn24h { get; set; }
        public string MarketId { get; set; }
        public virtual Market Market { get; set; }
        public DateTime? CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public int Status { get; set; }
        public Coin()
        {
            CreatedAt = DateTime.Now;
            UpdatedAt = DateTime.Now;
            Status = 1;
        }
    }
}