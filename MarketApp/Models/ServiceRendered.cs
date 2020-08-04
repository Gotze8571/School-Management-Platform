using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MarketApp.Models
{
    public class ServiceRendered
    {
        public long ServiceRenderedId { get; set; }
        public string ServiceRenderedName { get; set; }
        public string ServiceRenderedCategory { get; set; }
        public DateTime ServiceRenderedDateTime { get; set; }
    }
}