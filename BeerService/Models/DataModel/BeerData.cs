using System;
using System.Collections.Generic;

namespace BeerService.Models.DataModel
{
    public class BeerData
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Brand { get; set; }
        public byte [] Image { get; set; }
        public string Category { get; set; }
        public List<string> Tags { get; set; }
        public decimal Price { get; set; }
        public string Details { get; set; }
        public DateTime ListedSince { get; set; }

    }
}
