using BeerService.BusinessLogic;
using BeerService.Models.BusinessModel;
using Microsoft.AspNetCore.Mvc;
using System.Net;
using System.Threading.Tasks;

namespace BeerService.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class BeerRecomendationsController : ControllerBase
    {
        #region privateFields
        private readonly IBeerRecomendationsBL _beerRecommendationsBL;
        #endregion

        #region constructors
        public BeerRecomendationsController(IBeerRecomendationsBL beerRecomendationBL)
        {
            _beerRecommendationsBL = beerRecomendationBL;
        }
        #endregion

        #region publicMethods

        [HttpGet(nameof(GetBeerRecomendations))]
        [ProducesResponseType(typeof(BeerRecomendations),(int)HttpStatusCode.OK)]
        public async Task <IActionResult> GetBeerRecomendations()
        {
            return Ok(await _beerRecommendationsBL.GetBeerRecomendations());
        }

        [HttpPost(nameof(AddBeerRecomendations))]
        [ProducesResponseType(typeof(bool), (int)HttpStatusCode.OK)]
        public async Task<IActionResult> AddBeerRecomendations([FromBody]BeerRecomendations request)
        {
            return Ok(await _beerRecommendationsBL.AddBeerRecomendations(request));
        }
        #endregion
    }
}
