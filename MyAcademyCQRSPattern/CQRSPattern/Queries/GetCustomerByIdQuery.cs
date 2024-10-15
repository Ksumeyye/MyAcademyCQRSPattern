namespace MyAcademyCQRSPattern.CQRSPattern.Queries
{
	public class GetCustomerByIdQuery
	{
        public int Id { get; set; }

		public GetCustomerByIdQuery(int id)
		{
			Id = id;
		}
	}
}
