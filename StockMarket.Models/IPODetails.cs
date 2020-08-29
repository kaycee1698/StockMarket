using System;
using System.Collections.Generic;
using System.Text;

namespace StockMarket.Models
{
    class IPODetails
    {
        public long Id { get; set; }
        public string CompanyName { get; set; }
        public string StockExchange { get; set; }
        public decimal PricePerShare { get; set; }
        public int TotalNumberOfShares { get; set; }
        public DateTime OpenDateTime { get; set; }
        public string Remarks { get; set; }
    }
}
