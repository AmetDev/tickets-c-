using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Library_3
{
    internal class Query
    {
        OleDbCommand command;
        OleDbDataAdapter dataAdapter;
        OleDbConnection connection;
        DataTable bufferTable;
        public Query(string Conn )
        {
            connection = new OleDbConnection(Conn);
            bufferTable = new DataTable();
        }
        public DataTable UpdateLib()
        {
            connection.Open();
            dataAdapter = new OleDbDataAdapter("SELECT * FROM Книга", connection);
            bufferTable.Clear();
            dataAdapter.Fill(bufferTable);
            connection.Close();
            return bufferTable;
        }
        public DataTable UpdateLibFor(int ID)
        {
            connection.Open();
            dataAdapter = new OleDbDataAdapter($"SELECT * FROM Книга WHERE код_книги={ID}", connection);
            bufferTable.Clear();
            dataAdapter.Fill(bufferTable);
            connection.Close();
            return bufferTable;
        }
        public void AddLib(string author, string name, string date, int count)
        {
            connection.Open();
            command = new OleDbCommand("INSERT INTO Книга(автор, Название, Год, Страниц) VALUES(@author, @name, @date, @count)", connection);
            command.Parameters.AddWithValue("@author", author);
            command.Parameters.AddWithValue("@name", name);
            command.Parameters.AddWithValue ("@date", date);
            command.Parameters.AddWithValue("@count", count);
            command.ExecuteNonQuery();
            connection.Close();
        }
        public void RemoveLib(int ID)
        {
            connection.Open();
            command = new OleDbCommand($"DELETE * FROM Книга WHERE код_книги ={ID}", connection);
            command.ExecuteNonQuery();
            connection.Close();
        }

        public void EditLib(int ID, string author, string name, string date, int count)
        {
            connection.Open();
            command = new OleDbCommand("UPDATE  Книга SET автор=@author, Название=@name, Год=@date, Страниц=@count WHERE код_книги=@ID", connection);
            command.Parameters.AddWithValue("@author", author);
            command.Parameters.AddWithValue("@name", name);
            command.Parameters.AddWithValue("@date", date);
            command.Parameters.AddWithValue("@count", count);
            command.Parameters.AddWithValue("@ID", ID);
            command.ExecuteNonQuery();
            connection.Close();
        }
    }
}
