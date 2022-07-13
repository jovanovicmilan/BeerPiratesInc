

using BeerService.Models.BusinessModel;
using System.Threading.Tasks;

namespace BeerService.BusinessLogic
{
    public interface IBeerRecomendationsBL
    {
        #region interfaces
        Task<BeerRecomendations> GetBeerRecomendations();
        Task<bool> AddBeerRecomendations(BeerRecomendations request);
        #endregion

    }
}
