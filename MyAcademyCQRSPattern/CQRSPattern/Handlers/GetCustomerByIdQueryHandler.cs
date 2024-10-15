using AutoMapper;
using MyAcademyCQRSPattern.CQRSPattern.Queries;
using MyAcademyCQRSPattern.CQRSPattern.Results;
using MyAcademyCQRSPattern.DataAccess.Context;

namespace MyAcademyCQRSPattern.CQRSPattern.Handlers
{
	public class GetCustomerByIdQueryHandler
	{
		private readonly Context _context;
		private readonly IMapper _mapper;

		public GetCustomerByIdQueryHandler(Context context, IMapper mapper)
		{
			_context = context;
			_mapper = mapper;
		}
		public GetCustomerByIdQueryResult Handle(GetCustomerByIdQuery query)
		{
			var customer=_context.Customers.FirstOrDefault(x=>x.CustomerId==query.Id);
			var mapperCustomer=_mapper.Map<GetCustomerByIdQueryResult>(customer);
			return mapperCustomer;
		}
	}
}
