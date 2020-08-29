using System;
using System.Collections.Generic;
using System.Text;

namespace StockMarket.Models
{
    class StockExchange
    {
        public long Id { get; set; }
        public decimal StockExchangeValue { get; set; }
        public string Brief { get; set; }
        public string ContactAddress { get; set; }
        public string Remarks { get; set; }

    }
}
