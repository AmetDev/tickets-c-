using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tovar.Controller
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
        public DataTable UpdateVoid() 
        {
            connection.Open();
            dataAdapter = new OleDbDataAdapter("SELECT * FROM Товар", connection);
            bufferTable.Clear();
            dataAdapter.Fill(bufferTable);
            connection.Close();
            return bufferTable;
        }
        public DataTable UpdateVoidForUpdate(int ID)
        {
            connection.Open();
            dataAdapter = new OleDbDataAdapter($"SELECT * FROM Товар WHERE КодТовара={ID}", connection);
            bufferTable.Clear();
            dataAdapter.Fill(bufferTable);
            connection.Close();
            return bufferTable;
        }
        public void AddTovar(string name, int number, int count, int price)
        {
            connection.Open();
            command = new OleDbCommand("INSERT INTO Товар(Наименование, Номер, Количество, Цена) VALUES(@name, @number, @count, @price)", connection);
            command.Parameters.AddWithValue("@name", name);
            command.Parameters.AddWithValue("@number", number);
            command.Parameters.AddWithValue("@count", count);
            command.Parameters.AddWithValue("@price", price);
            command.ExecuteNonQuery();
            connection.Close();
        }
        public void DeleteTover(int ID)
        {
            connection.Open();
            command = new OleDbCommand($"DELETE * FROM Товар WHERE КодТовара ={ID}", connection);
            command.ExecuteNonQuery();
            connection.Close(); 
        }
        public void UpdateTovar(int ID, string name, int number, int count, int price)
        {
            connection.Open();
            command = new OleDbCommand("UPDATE Товар SET Наименование=@name, Номер=@number, Количество=@count, Цена=@price WHERE КодТовара = @ID", connection);
            command.Parameters.AddWithValue("@name", name);
            command.Parameters.AddWithValue("@number", number);
            command.Parameters.AddWithValue("@count", count);
            command.Parameters.AddWithValue("@price", price);
            command.Parameters.AddWithValue("@ID", ID);
            command.ExecuteNonQuery();
            connection.Close();
        }
        
    }
}
