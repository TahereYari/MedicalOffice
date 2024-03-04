using System.Data.SqlClient;

namespace Medical_Office
{
    internal class ServerConnection
    {
        private SqlConnection con;

        public ServerConnection(SqlConnection con)
        {
            this.con = con;
        }
    }
}