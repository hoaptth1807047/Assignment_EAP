using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Assignment_EAP.Models
{
    public class Coin
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string BaseAsset { get; set; }
        public string QuoteAsset { get; set; }
        public int LastPrice { get; set; }
        
    }
}