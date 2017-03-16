using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data.SqlClient;
using StudentLayerApp.MODEL;

namespace StudentLayerApp.DAL
{
    public class StudentGateway
    {

        string dbConnection = ConfigurationManager.ConnectionStrings["UniversityConString"].ConnectionString;
        public bool GetStudentByRegNo(string regno)
        {
            string query = "SELECT * FROM Students WHERE RegNo='" + regno + "'";
            SqlConnection connection = new SqlConnection(dbConnection);

            SqlCommand command = new SqlCommand(query, connection);

            connection.Open();
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                return true;
            }

            reader.Close();
            connection.Close();
            return false;
        }

        public int InsertStudent(MyStudent student)
        {
            string insertQ = "INSERT INTO Students (RegNo,Name,Address) VALUES('" + student.regNo + "','" + student.name + "','" + student.adress + "')";

            SqlConnection connection = new SqlConnection(dbConnection);

            SqlCommand command = new SqlCommand(insertQ, connection);

            connection.Open();

            int rowAffected = command.ExecuteNonQuery();

            connection.Close();

            return rowAffected;

        }

        public int UpdatetStudent(MyStudent student)
        {
            string insertQ = "UPDATE Students SET Name='" + student.name + "',Address='" + student.adress + "' WHERE ID='" + student.Id + "'";

            SqlConnection connection = new SqlConnection(dbConnection);

            SqlCommand command = new SqlCommand(insertQ, connection);

            connection.Open();

            int rowAffected = command.ExecuteNonQuery();

            connection.Close();

            return rowAffected;

        }

        public MyStudent GetStudentById(int studentId)
        {
            string query = "SELECT * FROM Students WHERE ID='" + studentId + "'";
            SqlConnection connection = new SqlConnection(dbConnection);

            SqlCommand command = new SqlCommand(query, connection);

            connection.Open();
            SqlDataReader reader = command.ExecuteReader();
            MyStudent student = new MyStudent();
            while (reader.Read())
            {
                student.Id = Convert.ToInt32(reader["ID"].ToString());
                student.regNo = reader["RegNo"].ToString();
                student.name = reader["Name"].ToString();
                student.adress = reader["Address"].ToString();
            }

            reader.Close();
            connection.Close();
            return student;
        }

        public List<MyStudent> GetStudentsByName(string studentname)
        {
            string query = "EXEC sp_GetStudentsbyName '" + studentname + "'";
            SqlConnection connection = new SqlConnection(dbConnection);

            SqlCommand command = new SqlCommand(query, connection);

            connection.Open();
            SqlDataReader reader = command.ExecuteReader();
            List<MyStudent> students = new List<MyStudent>();
            while (reader.Read())
            {
                //for(int a=1;a<=has
                MyStudent student = new MyStudent();
                student.Id = Convert.ToInt32(reader["ID"].ToString());
                student.regNo = reader["RegNo"].ToString();
                student.name = reader["Name"].ToString();
                student.adress = reader["Address"].ToString();
                students.Add(student);
            }

            reader.Close();
            connection.Close();
            return students;
        }

        public List<MyStudent> GetAllStudents()
        {
            string query = "SELECT * FROM Students";
            SqlConnection connection = new SqlConnection(dbConnection);

            SqlCommand command = new SqlCommand(query, connection);

            connection.Open();
            SqlDataReader reader = command.ExecuteReader();
            List<MyStudent> students = new List<MyStudent>();
            while (reader.Read())
            {
                MyStudent student = new MyStudent();
                student.Id = Convert.ToInt32(reader["ID"].ToString());
                student.regNo = reader["RegNo"].ToString();
                student.name = reader["Name"].ToString();
                student.adress = reader["Address"].ToString();
                students.Add(student);
            }

            reader.Close();
            connection.Close();
            return students;
        }

    }
}
