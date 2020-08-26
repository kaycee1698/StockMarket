using System;
using System.Collections.Generic;

namespace StockMarket.Models
{
    public class Company
    {
        public long Id { get; set; }
        public string CompanyName { get; set; }
        public string Turnover { get; set; }
        public string CEO { get; set; }
        public List<string> BoardOfDirectors { get; set; }
        public List<string> ListedInStockExchanges { get; set; }
        public string Sector { get; set; }
        public string Brief { get; set; }
        public string StockCode { get; set; }
    }
}
