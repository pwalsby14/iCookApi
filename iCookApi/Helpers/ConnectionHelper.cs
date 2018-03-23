using System;
using System.Data.SqlClient;


namespace iCookApi.Helpers
{
    public class ConnectionHelper
    {
        public ConnectionHelper()
        {
            
        }

        public static SqlConnection ConnectToDatabase(string databaseName) 
        {
            SqlConnectionStringBuilder builder = new SqlConnectionStringBuilder();
            builder.DataSource = ConfigVals.DatabaseServer;
            builder.UserID = ConfigVals.DatabaseUser;
            builder.Password = ConfigVals.DatabasePassword;
            builder.InitialCatalog = databaseName;

            try
            {
                SqlConnection connection = new SqlConnection(builder.ConnectionString);
                return connection;
            }
            catch(Exception ex)
            {
                throw new ApplicationException($"An error occurred whilst connection to the database: {ex.Message}\n {ex.StackTrace}");
            }
        }
    }
}