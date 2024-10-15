namespace MyAcademyCQRSPattern.CQRSPattern.Commands
{
	public class UpdateCustomerCommand
	{
        public int CustomerId { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string City { get; set; }
    }
}
