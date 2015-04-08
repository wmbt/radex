using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

namespace Titan2.Models
{
    public class TableItem
    {
        public int Id { get; private set; }
        public string Offer { get; set; }
        public string Mark { get; set; }
        public double Price { get; set; }
        public string Size { get; set; }
        
        public TableItem(IDataRecord r) 
        {
            Id = (int)r["ID"];
            Offer = (string)r["OFFER"];
            Mark = (string)r["MARK"];
            Price = (double)r["PRICE"];
            Size = (string)r["SIZE"];
        }
    }

    public class PriceTable 
    {
        public TableItem[] Items { get; set; }
        public string SortColumn { get; set; }
        public string SortOrder { get; set; }
    }
}