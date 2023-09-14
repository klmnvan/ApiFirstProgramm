using System.ComponentModel.DataAnnotations.Schema;

namespace ApiFirstProgramm.ViewModel
{
	[Table ("person")]
	public class person
	{
		[Column ("idPerson")]
		public int Id { get; set; }
		[Column("F")]
		public string F {  get; set; }
		[Column("I")]
		public string I {  get; set; }
		[Column("O")]
		public string O {  get; set; }
		[Column("addressPerson")]
		public string AddressPerson {  get; set; }
		[Column("age")]
		public int Age { get; set; }
	}
}
