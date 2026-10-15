using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    public class Assest
    {
        public int AssetId { get; set; }
        public string SystemName { get; set; }
        public string Manufacturer { get; set; }
        public string Model { get; set; }
        public string AssetType { get; set; }
        public string IPAddress { get; set; }
        public DateTime? PurchaseDate { get; set; }
        public string Notes { get; set; }
    }
    
}
