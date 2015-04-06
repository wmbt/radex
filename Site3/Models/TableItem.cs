using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

namespace Site3.Models
{
    public class TableItem
    {
        public int Id { get; private set; }
        public string Size { get; set; }
        public string SteelMark { get; set; }
        public double Price { get; set; }
        public string Product { get; set; }
        
        public TableItem(IDataRecord r) 
        {
            Id = (int)r["ID"];
            Size = (string)r["SIZE"];
            SteelMark = (string)r["STEEL_MARK"];
            Price = (double)r["PRICE"];
            Product = (string)r["PRODUCT"];
        }
    }

    public class PriceTable 
    {
        public TableItem[] Items { get; set; }
        public string SortColumn { get; set; }
        public string SortOrder { get; set; }
    }
}