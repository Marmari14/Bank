using System.Data;
using System.Data.SqlClient;

namespace Bank
{
    internal static class MyDataBase
    {
        private static SqlConnection sqlConnection = new SqlConnection("Data Source=DESKTOP-I12KO2O;Initial Catalog=Bank;Integrated Security=True");
        private static SqlCommand sqlCommand;
        private static SqlDataAdapter adapter = new SqlDataAdapter();
        private static DataTable table;

        public static void openConnection()
        {
            if (sqlConnection.State != ConnectionState.Closed)
                return;
            sqlConnection.Open();
        }

        public static bool authorization(string login, string pass, out int id, out string table)
        {
            string query = "SELECT COUNT(*) FROM Users WHERE Login=@login AND Password=@Password";
            openConnection();
            sqlCommand = new SqlCommand(query, sqlConnection);
            sqlCommand.Parameters.AddWithValue("@login", login);
            sqlCommand.Parameters.AddWithValue("@Password", pass);
            int count = (int)sqlCommand.ExecuteScalar();
            id = 0;
            table = "";
            if (count > 0)
            {
                query = "select dbo.searchIDByLogin(@login, @Password)";
                sqlCommand = new SqlCommand(query, sqlConnection);
                sqlCommand.Parameters.AddWithValue("@login", login);
                sqlCommand.Parameters.AddWithValue("@Password", pass);
                id = (int)sqlCommand.ExecuteScalar();
                query = "select dbo.searchTableByLogin(@login, @Password)";
                sqlCommand = new SqlCommand(query, sqlConnection);
                sqlCommand.Parameters.AddWithValue("@login", login);
                sqlCommand.Parameters.AddWithValue("@Password", pass);
                table = (string)sqlCommand.ExecuteScalar();
            }
            return count > 0;
        }

        public static DataTable getTable(string query)
        {
            sqlCommand = new SqlCommand(query, sqlConnection);
            adapter.SelectCommand = sqlCommand;
            table = new DataTable();
            adapter.Fill(table);
            return table;
        }
        public static DataTable getItemsForComboBox(string name_table)
        {
            string query = $"select ID, Name from {name_table} where Deleted=0";
            return getTable(query);
        }

        public static int insert_data(string query)
        {
            openConnection();
            sqlCommand = new SqlCommand(query, sqlConnection);
            return sqlCommand.ExecuteNonQuery() >= 1 ? 0 : -1;
        }

        public static object getOneItem(string query) 
        {
            sqlCommand = new SqlCommand(query, sqlConnection);
            return sqlCommand.ExecuteScalar();
        }
    }
}
