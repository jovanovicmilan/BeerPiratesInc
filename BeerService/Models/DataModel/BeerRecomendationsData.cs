using System.Collections.Generic;

namespace BeerService.Models.DataModel
{
    public class BeerRecomendationsData
    {
        public int Id { get; set; }
        public List<BeerData> Beers { get; set; }

    }
}
