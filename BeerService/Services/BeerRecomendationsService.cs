

using BeerService.Models.DataModel;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.IO;
using System.Reflection;
using System.Text.Json;
using System.Threading.Tasks;

namespace BeerService.Services
{
    public class BeerRecomendationsService : IBeerRecomendationsService
    {

        #region privateFields

        private readonly ILogger<BeerRecomendationsService> _logger;

        #endregion

        #region constructors

        public BeerRecomendationsService(ILogger<BeerRecomendationsService> logger)
        {
            _logger = logger;
        }

        #endregion

        #region publicMethods

        public async Task<BeerRecomendationsData> GetBeerRecomendations()
        {
            //communication with database or other service

            List<BeerData> beers = new List<BeerData>();
            var result = new BeerRecomendationsData();

            using (StreamReader r = new StreamReader(@".\Mock\beerRecomendations1.json"))
            {
                string json = await r.ReadToEndAsync();
                result = JsonSerializer.Deserialize<BeerRecomendationsData>(json);
                _logger.LogInformation("Sucess");
            }

            return result;
         }

        public async Task<bool> AddBeerRecomendations(BeerRecomendationsData request)
        {
            //communication with database or other service

            string jsonString = JsonSerializer.Serialize(request, new JsonSerializerOptions() { WriteIndented = true });

            string filename = string.Format("beerRecomendations{0}.json", request.Id);

            using (StreamWriter outputFile = new StreamWriter(filename))
            {
               await outputFile.WriteLineAsync(jsonString);
            }

            return true;

        }

        #endregion

        #region privateMethods

        #endregion
    }
}
