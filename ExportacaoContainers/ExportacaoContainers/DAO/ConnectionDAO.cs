using System.Data.SqlClient;

namespace ExportacaoContainers.DAO
{
    sealed class ConnectionDAO
    {
        private static SqlConnection conn = null;

        public static SqlConnection getConnection()
        {
            if (conn == null)
            {
                conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\mayco\Documents\Multivix\bessa\ExportacaoContainers\ExportacaoContainers\Data\Database1.mdf;Integrated Security=True");
            }
            return conn;
        }
    }
}
