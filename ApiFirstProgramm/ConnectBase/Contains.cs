using System.Data.SqlClient;

namespace ApiFirstProgramm.ConnectBase
{
	public class Contains
	{
		public static string ConnectSqlBase
		{
			get
			{
				var sqlConnect = new SqlConnectionStringBuilder
				{
					DataSource = "DESKTOP-SQHHTI4\\SQLEXPRESS",
					InitialCatalog = "toklim",
					IntegratedSecurity = true,
					TrustServerCertificate = true
				};
				return sqlConnect.ToString();
			}
		}
	}
}