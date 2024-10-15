using AutoMapper;
using MyAcademyCQRSPattern.CQRSPattern.Results;
using MyAcademyCQRSPattern.DataAccess.Context;

namespace MyAcademyCQRSPattern.CQRSPattern.Handlers
{
	public class GetCustomerQueryHandler
	{
		private readonly Context _context; //Contextten de _context field
		private readonly IMapper _mapper;

		public GetCustomerQueryHandler(Context context, IMapper mapper)
		{
			_mapper = mapper;
			_context = context;
		}
		public List<GetCustomerQueryResult>Handle() //getcustomerqueryresult türünde geri dönüşü olan bir handle methodu yazdım.
		{
			var values = _context.Customers.ToList();
			var mappedResult =_mapper.Map<List<GetCustomerQueryResult>>(values);
			return mappedResult;
		
		}
	}
}
