using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

namespace Site2.Models
{
    public class TableItem
    {
        public int Id { get; private set; }
        public string Size { get; set; }
        public string SteelMark { get; set; }
        public double Price { get; set; }
        public string Note { get; set; }
        
        public TableItem(IDataRecord r) 
        {
            Id = (int)r["ID"];
            Size = (string)r["SIZE"];
            SteelMark = (string)r["STEEL_MARK"];
            Price = (double)r["PRICE"];
            Note = (string)r["NOTE"];
        }
    }

    public class PriceTable 
    {
        public TableItem[] Items { get; set; }
        public string SortColumn { get; set; }
        public string SortOrder { get; set; }
    }

    public class Tables 
    {
        public PriceTable T1 { get; set; }
        public PriceTable T2 { get; set; }
    }
}