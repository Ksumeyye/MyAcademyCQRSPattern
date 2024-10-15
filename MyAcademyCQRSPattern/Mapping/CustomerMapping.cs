using AutoMapper;
using MyAcademyCQRSPattern.CQRSPattern.Commands;
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
            CreateMap<CreateCustomerCommand, Customer>().ReverseMap();
            CreateMap<UpdateCustomerCommand, Customer>().ReverseMap();
            CreateMap<GetCustomerByIdQueryResult,UpdateCustomerCommand>().ReverseMap();
        }
    }
}
