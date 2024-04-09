using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.Entity;
using System.Data.SQLite;
using UIController.Models;

namespace UIController._Repositories
{
    public class StudentRepository : BaseRepositories, IRepository
    {
        #region Сделано
        public StudentRepository(string connectionString) { 
            this.connectionString = connectionString;   
        }
        #endregion

        public void Add(StudentModel studentModel)
        {
            using (var connection = new SQLiteConnection(connectionString))
            using (var command = new SQLiteCommand())
            {
                connection.Open();
                command.Connection = connection;
                command.CommandText = "INSERT INTO MyClass VALUES (@NAME,  @AGE);";
                command.Parameters.Add("@NAME", (DbType)SqlDbType.NVarChar).Value = studentModel.Name;
                command.Parameters.Add("@AGE", (DbType)SqlDbType.Int).Value = studentModel.Age;
                command.ExecuteNonQuery();
            }
        }

        public void Delete(int id)
        {
            using (var connection = new SQLiteConnection(connectionString))
            using (var command = new SQLiteCommand())
            {
                connection.Open();
                command.Connection = connection;
                command.CommandText = "DELETE FROM MyClass WHERE ID=@ID);";
                command.Parameters.Add("@ID", (DbType)SqlDbType.Int).Value = id;
                command.ExecuteNonQuery();
            }
        }

        public void Edit(StudentModel studentModel)
        {
            using (var connection = new SQLiteConnection(connectionString))
            using (var command = new SQLiteCommand())
            {
                connection.Open();
                command.Connection = connection;
                command.CommandText = "UPDATE MyClass SET NAME=@NAME, AGE=@AGE WHERE ID=@ID;";
                command.Parameters.Add("@ID", (DbType)SqlDbType.Int).Value = studentModel.Id;
                command.Parameters.Add("@NAME", (DbType)SqlDbType.NVarChar).Value = studentModel.Name;
                command.Parameters.Add("@AGE", (DbType)SqlDbType.Int).Value = studentModel.Age;
                command.ExecuteNonQuery();
            }
        }

        #region Сделано
        public IEnumerable<StudentModel> GetAll()
        {
            var studentList = new List<StudentModel>();
            using (var connection=new SQLiteConnection(connectionString))
                using (var command = new SQLiteCommand())
            {
                connection.Open();
                command.Connection = connection;
                command.CommandText = "SELECT * FROM MyClass ORDER BY ID DESC;";
                using(var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        var studentModel = new StudentModel();
                        studentModel.Id = (int)reader[0];
                        studentModel.Name = reader[1].ToString();
                        studentModel.Age = (int)reader[2];
                        studentList.Add(studentModel);
                    }
                }

            }
            return studentList;
        }
        #endregion

        public IEnumerable<StudentModel> GetByValue(string value)
        {

            var studentList = new List<StudentModel>();

            int studentID = int.TryParse(value, out _) ? Convert.ToInt32(value) : 0;
            string studentName = value;

            using (var connection = new SQLiteConnection(connectionString))
            using (var command = new SQLiteCommand())
            {
                connection.Open();
                command.Connection = connection;
                command.CommandText = @"SELECT * FROM MyClass 
                                        WHERE ID=@id OR Name LIKE @name+'%' 
                                        ORDER BY ID DESC";
                command.Parameters.Add("@id", (DbType)SqlDbType.Int).Value = studentID;
                command.Parameters.Add("@name", (DbType)SqlDbType.NVarChar).Value = studentName;
                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        var studentModel = new StudentModel();
                        studentModel.Id = (int)reader[0];
                        studentModel.Name = reader[1].ToString();
                        studentModel.Age = (int)reader[2];
                        studentList.Add(studentModel);
                    }
                }

            }
            return studentList;
        }

    }
}
