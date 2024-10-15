using AutoMapper;
using MyAcademyCQRSPattern.CQRSPattern.Commands;
using MyAcademyCQRSPattern.DataAccess.Context;
using MyAcademyCQRSPattern.DataAccess.Entities;

namespace MyAcademyCQRSPattern.CQRSPattern.Handlers
{
	public class CreateCustomerCommandHandler
	{
		private readonly Context _context;
		private readonly IMapper _mapper;

		public CreateCustomerCommandHandler(Context context, IMapper mapper)
		{
			_context = context;
			_mapper = mapper;
		}
		public void Handle(CreateCustomerCommand command)
		{
			var newCustomer = _mapper.Map<Customer>(command);
			_context.Customers.Add(newCustomer);
			_context.SaveChanges();
		}
	}
}
