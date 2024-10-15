using AutoMapper;
using MyAcademyCQRSPattern.CQRSPattern.Commands;
using MyAcademyCQRSPattern.DataAccess.Context;
using MyAcademyCQRSPattern.DataAccess.Entities;

namespace MyAcademyCQRSPattern.CQRSPattern.Handlers
{
	public class UpdateCustomerCommandHandler
	{
		private readonly Context _context;
		private readonly IMapper _mapper;

		public UpdateCustomerCommandHandler(Context context, IMapper mapper)
		{
			_context = context;
			_mapper = mapper;
		}
		public void Handle(UpdateCustomerCommand command)
		{
			var updateCustomer = _mapper.Map<Customer>(command);
			_context.Customers.Update(updateCustomer);
			_context.SaveChanges();
		}
	}
}
