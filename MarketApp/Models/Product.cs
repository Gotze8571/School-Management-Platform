using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MarketApp.Models
{
    public class Product
    {
        public long ProductId { get; set; }
        public string ProductName { get; set; }
        public string ProductCategory { get; set; }
        public DateTime DeliveryDate { get; set; }
    }
}