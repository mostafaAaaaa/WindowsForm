using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WinProject.IRepositories;
using WinProject.Models;

namespace WinProject.Repositories
{
    public class BookRepositoy : IBookRepository
    {
        private readonly string conncetionString;
        public BookRepositoy()
        {
            conncetionString = "data source=.; initial catalog=Library; integrated security=true";
        }
        public DataTable GetAll()
        {
            SqlConnection connection = new SqlConnection(conncetionString);
            SqlCommand command = new SqlCommand("select * from Book", connection);

            //DataSet
            DataTable dt = new DataTable();

            //SqlDataAdapter
            SqlDataReader reader = null;
            connection.Open();

            reader = command.ExecuteReader();
            dt.Load(reader);
            //while (reader.Read())
            //{
            //    //GetString
            //    //GetValues
            //    var result = reader.GetValue(1);
            //}

            connection.Close();

            return dt;
        }
        public DataTable GetAllByProcedure()
        {
            DataTable dt = new DataTable();

            SqlConnection connection = new SqlConnection(conncetionString);
            SqlCommand command = new SqlCommand("Usp_Book_GetAll", connection);
            command.CommandType = CommandType.StoredProcedure;

            connection.Open();

            SqlDataReader reader = command.ExecuteReader();
            dt.Load(reader);

            connection.Close();

            return dt;
        }

        public Book GetById(int id)
        {
            Book book = new Book();

            SqlConnection connection = new SqlConnection(conncetionString);
            SqlCommand command = new SqlCommand("Usp_Book_GetById", connection);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.AddWithValue("@Id", id);

            connection.Open();

            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                if (reader.HasRows)
                {
                    book.Id = (int)reader["Id"];
                    book.Name = reader["Name"].ToString();
                    book.PageCount = (int)reader["PageCount"];
                    book.Publisher = reader["Publisher"].ToString();
                }

            }

            connection.Close();

            return book;
        }

        public int Insert(Book book)
        {
            int result = 0;
            SqlConnection connection = new SqlConnection(conncetionString);
            SqlCommand command = new SqlCommand("USP_Book_Insert", connection);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.AddWithValue("@Name", book.Name);
            command.Parameters.AddWithValue("@PageCount", book.PageCount);
            command.Parameters.AddWithValue("@Publisher", book.Publisher);

            connection.Open();
            result = command.ExecuteNonQuery();
            connection.Close();
            return result;
        }
    }
}
