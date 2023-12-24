using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace avtostand3
{
    internal class Query
    {
        OleDbCommand command;
        OleDbDataAdapter dataAdapter;
        OleDbConnection connection;
        DataTable bufferTable;
        public Query(string Conn)
        {
            connection = new OleDbConnection(Conn);
            bufferTable = new DataTable();

        }
        public DataTable UpdateAvto() { 
            connection.Open();
            dataAdapter = new OleDbDataAdapter("SELECT * FROM автостоянка", connection);
            bufferTable.Clear();
            dataAdapter.Fill(bufferTable);
            connection.Close();
            return bufferTable;
          

        }
        public void AddAvto(int count, string name, int count_max, int price, string city)
        { 
        
            connection.Open();
            command = new OleDbCommand("INSERT INTO автостоянка(количество_машин, название_стоянок, допустимое_количество, плата, город) VALUES(@count, @name, @count_max, @price, @city)", connection);
            command.Parameters.AddWithValue("@count", count);
            command.Parameters.AddWithValue("@name", name);
            command.Parameters.AddWithValue ("@count_max", count_max);
            command.Parameters.AddWithValue("@price", price);
            command.Parameters.AddWithValue("@city", city);
            command.ExecuteNonQuery();
            connection.Close();
        }
        public void DeleteAvto(int ID)
        {
            connection.Open();
            command = new OleDbCommand($"DELETE * FROM автостоянка WHERE Кодстоянки={ID}", connection);
            command.ExecuteNonQuery();
            connection.Close();

        }
        public void EditAvto(int ID, int count, string name, int count_max, int price, string city)
        {
            connection.Open();
            command = new OleDbCommand("UPDATE автостоянка SET количество_машин=@count, название_стоянок=@name, допустимое_количество=@count_max, плата=@price, город=@city WHERE Кодстоянки=@ID", connection);
            command.Parameters.AddWithValue("@count", count);
            command.Parameters.AddWithValue("@name", name);
            command.Parameters.AddWithValue("@count_max", count_max);
            command.Parameters.AddWithValue("@price", price);
            command.Parameters.AddWithValue("@city", city);
            command.Parameters.AddWithValue("@ID", ID);
            command.ExecuteNonQuery();
            connection.Close();
        }
        public DataTable GetUpdate(int ID)
        {
            connection.Open();
            dataAdapter = new OleDbDataAdapter($"SELECT * FROM автостоянка WHERE Кодстоянки={ID}", connection);
            bufferTable.Clear();
            dataAdapter.Fill(bufferTable);
            connection.Close();
            return bufferTable;
        }
    }
}
