using AutoMapper;

namespace BeerService.Models.Mapper
{
    public class MapperProfile : Profile
    {

        public MapperProfile()
        {
            #region business2dataMapper
            CreateMap<BusinessModel.Beer, DataModel.BeerData>();
            CreateMap<BusinessModel.BeerRecomendations, DataModel.BeerRecomendationsData>();
            #endregion

            #region data2BusinessMapper
            CreateMap<DataModel.BeerData, BusinessModel.Beer>();
            CreateMap<DataModel.BeerRecomendationsData, BusinessModel.BeerRecomendations>();
            #endregion

        }

    }
}
