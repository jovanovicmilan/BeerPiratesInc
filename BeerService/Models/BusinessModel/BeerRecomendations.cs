using System.Collections.Generic;

namespace BeerService.Models.BusinessModel
{
    /// <summary>
    /// Beer Recomendations
    /// </summary>
    public class BeerRecomendations
    {
        /// <summary>
        /// Beer Recomendations Id
        /// </summary>
        public int Id { get; set; }
        /// <summary>
        /// Beer Recomendations List
        /// </summary>
        public List<Beer> Beers { get; set; }

    }
}
