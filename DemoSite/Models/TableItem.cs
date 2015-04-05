using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

namespace DemoSite.Models
{
    public class TableItem
    {
        public long Id { get; private set; }
        public string Kind { get; set; }
        public double Width { get; set; }
        public string SteelMark { get; set; }
        public double Price { get; set; }

        public TableItem(IDataRecord r) 
        {
            Id = (long)r["ID"];
            Kind = (string)r["KIND"];
            Width = (double)r["WIDTH"];
            SteelMark = (string)r["STEEL_MARK"];
            Price = (double)r["PRICE"];
        }
    }

    public class PriceTable 
    {
        public TableItem[] Items { get; set; }
        public string SortColumn { get; set; }
        public string SortOrder { get; set; }
    }
}