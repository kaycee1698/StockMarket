using System;
using System.Collections.Generic;
using System.Text;

namespace StockMarket.Models
{
    class StockPrice
    {
        public long Id { get; set; }
        public int StockExchange { get; set; }
        public decimal CurrentPrice { get; set; }
        public DateTime Date { get; set; }
        public DateTime Time { get; set; }
    }
}
