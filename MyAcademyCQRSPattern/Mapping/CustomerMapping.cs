using AutoMapper;
using MyAcademyCQRSPattern.CQRSPattern.Results;
using MyAcademyCQRSPattern.DataAccess.Entities;

namespace MyAcademyCQRSPattern.Mapping
{
	public class CustomerMapping:Profile
	{
        public CustomerMapping()
        {
            CreateMap<GetCustomerQueryResult, Customer>().ReverseMap();
            CreateMap<GetCustomerByIdQueryResult, Customer>().ReverseMap();
        }
    }
}
