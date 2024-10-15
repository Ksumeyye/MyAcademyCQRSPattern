using MyAcademyCQRSPattern.CQRSPattern.Commands;
using MyAcademyCQRSPattern.DataAccess.Context;

namespace MyAcademyCQRSPattern.CQRSPattern.Handlers
{
	public class RemoveCustomerCommandHandler
	{
		private readonly Context _context;

		public RemoveCustomerCommandHandler(Context context)
		{
			_context = context;
		}
		public void Handle(RemoveCustomerCommand command)
		{
			var customer = _context.Customers.FirstOrDefault(x => x.CustomerId == command.Id);
			_context.Customers.Remove(customer);
			_context.SaveChanges();
		}
	}
}
