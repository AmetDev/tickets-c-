using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data;
using System.Data.Common;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AVTOGARAJ.Controller
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
        public DataTable UpdateFirst()
        {
            connection.Open();
            dataAdapter = new OleDbDataAdapter("SELECT * FROM Машина", connection);
            bufferTable.Clear();
            dataAdapter.Fill(bufferTable);
            connection.Close();
            return bufferTable;
        }
        public DataTable UpdateFirstForUpdate(int ID)
        {
            connection.Open();
            dataAdapter = new OleDbDataAdapter($"SELECT * FROM Машина WHERE код_машина={ID}", connection);
            bufferTable.Clear();
            dataAdapter.Fill(bufferTable);
            connection.Close();
            return bufferTable;
        }
        public void Add(string marka, string date, int price, int number) 
        {
            connection.Open();
            command = new OleDbCommand($"INSERT INTO Машина (Марка, Год, Цена, номер_двигателя) VALUES(@marka, @date, @price, @number)", connection);
            command.Parameters.AddWithValue("@marka", marka);
            command.Parameters.AddWithValue("@date", date);
            command.Parameters.AddWithValue("@price", price);
            command.Parameters.AddWithValue("@number", number);
            command.ExecuteNonQuery();
            connection.Close();
        }
        public void Delete(int ID)
        {
            connection.Open();
            command = new OleDbCommand($"DELETE * FROM Машина WHERE код_машина={ID}", connection);
            command.ExecuteNonQuery();
            connection.Close();
            


        }
        public void Edit(int ID, string marka, string date, int price, int number)
        {
            connection.Open();
            command = new OleDbCommand($"UPDATE Машина SET Марка=@marka, Год=@date, Цена=@price, номер_двигателя=@number WHERE код_машина={ID}", connection);
            command.Parameters.AddWithValue("@marka", marka);
            command.Parameters.AddWithValue("@date", date);
            command.Parameters.AddWithValue("@price", price);
            command.Parameters.AddWithValue("@number", number);
            command.ExecuteNonQuery();
            connection.Close();
        }
        public DataTable Seacrh(string SearchItem)
        {
            connection.Open();
            string query = $"SELECT * FROM Машина WHERE Марка LIKE @Seacrh";
            dataAdapter = new OleDbDataAdapter(query, connection);
            dataAdapter.SelectCommand.Parameters.AddWithValue("@Seacrh", "%" + SearchItem + "%");
            bufferTable.Clear();
            dataAdapter.Fill(bufferTable);
            connection.Close();
            return bufferTable;
        }

    }
    
}
