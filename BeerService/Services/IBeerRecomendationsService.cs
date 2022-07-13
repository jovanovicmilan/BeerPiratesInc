


using BeerService.Models.DataModel;
using System.Threading.Tasks;

namespace BeerService.Services
{
    public interface IBeerRecomendationsService
    {
        #region interfaces
        Task<BeerRecomendationsData> GetBeerRecomendations();
        Task<bool> AddBeerRecomendations(BeerRecomendationsData request);
        #endregion

    }
}
