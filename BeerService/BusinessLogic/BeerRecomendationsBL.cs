using AutoMapper;
using BeerService.Models.BusinessModel;
using BeerService.Models.DataModel;
using BeerService.Services;
using Microsoft.Extensions.Logging;
using System;
using System.Threading.Tasks;

namespace BeerService.BusinessLogic
{
    public class BeerRecomendationsBL : IBeerRecomendationsBL
    {

        #region privateFields
        private readonly IMapper _mapper;
        private readonly ILogger<BeerRecomendationsBL> _logger;
        private readonly IBeerRecomendationsService _beerRecomendationsService;
        #endregion

        #region constructors
        public BeerRecomendationsBL(IMapper mapper, ILogger<BeerRecomendationsBL> logger, IBeerRecomendationsService beerRecomendationsService)
        {
            _mapper = mapper;
            _logger = logger;
            _beerRecomendationsService = beerRecomendationsService;

        }

        #endregion

        #region publicMethods
        public async Task<BeerRecomendations> GetBeerRecomendations()
        {
            var result = new BeerRecomendations();

            try
            {
                var response = await _beerRecomendationsService.GetBeerRecomendations();
                result = _mapper.Map<BeerRecomendations>(response);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex.Message);
            }

            return result;

        }


        public async Task<bool> AddBeerRecomendations(BeerRecomendations request)
        {
            bool response=false;

            try
            {
                var requestData = _mapper.Map<BeerRecomendationsData>(request);

                response = await _beerRecomendationsService.AddBeerRecomendations(requestData);
                
            }
            catch (Exception ex)
            {
                _logger.LogError(ex.Message);
            }

            return response;
        }
        #endregion

        #region privateMethods

        #endregion


    }
}
