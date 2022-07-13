using System;
using System.Collections.Generic;

namespace BeerService.Models.BusinessModel
{
    /// <summary>
    /// Beer
    /// </summary>
    public class Beer
    {   /// <summary>
        /// Beer Id
        /// </summary>
        public int Id { get; set; }
        /// <summary>
        /// Beer Name
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// Beer Brand
        /// </summary>
        public string Brand { get; set; }
        /// <summary>
        /// Beer Image
        /// </summary>
        public byte [] Image { get; set; }
        /// <summary>
        /// Beer Category
        /// </summary>
        public string Category { get; set; }
        /// <summary>
        /// Beer Tags
        /// </summary>
        public List<string> Tags { get; set; }
        /// <summary>
        /// Beer Price
        /// </summary>
        public decimal Price { get; set; }
        /// <summary>
        /// Beer Details
        /// </summary>
        public string Details { get; set; }
        /// <summary>
        /// Beer Listed Since
        /// </summary>
        public DateTime ListedSince { get; set; }


    }
}
