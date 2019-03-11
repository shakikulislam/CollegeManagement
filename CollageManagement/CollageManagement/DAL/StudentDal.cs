using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CollageManagement.Models;

namespace CollageManagement.DAL
{
    public class StudentDal
    {
        private static string _connectionString = ConfigurationManager.ConnectionStrings["ConnectionDatabase"].ToString();
        private static SqlConnection _sqlConnection = new SqlConnection(_connectionString);
        private SqlCommand sqlCommand = new SqlCommand("", _sqlConnection);

        private SqlDataReader sqlDataReader;

        public bool AddStudent(Student student)
        {
            string querry = @"INSERT INTO StudentTable(StudentId,Name,Session)VALUES('" + student.Id + "','" + student.Name + "','" + student.Session + "')";
            sqlCommand.CommandText = querry;
            _sqlConnection.Open();
            int isExecute=sqlCommand.ExecuteNonQuery();
            if (isExecute>0)
            {
                return true;
            }
            else
            {
                return false;
            }
            _sqlConnection.Close();
        }

        public bool CheckUnique(Student student)
        {
            String querry = @"SELECT StudentId FROM StudentTable WHERE StudentId='" + student.Id + "'";
            sqlCommand.CommandText = querry;
            _sqlConnection.Open();
            sqlDataReader = sqlCommand.ExecuteReader();
            if (sqlDataReader.Read())
            {
                return true;
            }
            else
            {
                return false;
            }
            _sqlConnection.Close();
        }
    }
}
