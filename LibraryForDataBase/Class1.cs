using System;
using System.Data;
using System.Data.SqlClient;

namespace LibraryForDataBase
{
    public class MyDataBase
    {
        private SqlConnection sqlConnection;
        private SqlCommand sqlCommand;
        private SqlDataAdapter adapter = new SqlDataAdapter();
        private DataTable table;
        public MyDataBase(string strConnection)
        {
            sqlConnection = new SqlConnection(strConnection);
        }

        public void openConnection()
        {
            if (sqlConnection.State != ConnectionState.Closed)
                return;
            sqlConnection.Open();
        }

        public bool authorization(string login, string pass, out int id, out string table)
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

        public DataTable getTable(string query)
        {
            try
            {
                openConnection();
                sqlCommand = new SqlCommand(query, sqlConnection);
                adapter.SelectCommand = sqlCommand;
                table = new DataTable();
                adapter.Fill(table);
                return table;
            }
            catch
            {
                throw new Exception("Произошла ошибка! Проверьте входные данные!");
            }
        }
        public DataTable getItemsForComboBox(string name_table)
        {
            try
            {
                openConnection();
                string query = $"select ID, Name from {name_table} where Deleted=0";
                return getTable(query);
            }
            catch 
            {
                throw new Exception("Таблица не найдена!");
            }
        }

        public int insert_data(string query)
        {
            try
            {
                openConnection();
                sqlCommand = new SqlCommand(query, sqlConnection);
                return sqlCommand.ExecuteNonQuery() >= 1 ? 0 : -1;
            }
            catch 
            {
                throw new Exception("Произошла ошибка! Проверьте входные данные!");
            }
        }

        public object getOneItem(string query)
        {
            try
            {
                openConnection();
                sqlCommand = new SqlCommand(query, sqlConnection);
                return sqlCommand.ExecuteScalar();
            }
            catch
            {
                throw new Exception("Произошла ошибка! Проверьте входные данные!");
            }
        }

    }
}
