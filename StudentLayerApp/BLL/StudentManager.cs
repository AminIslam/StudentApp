using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StudentLayerApp.MODEL;
using StudentLayerApp.DAL;

namespace StudentLayerApp.BLL
{
    public class StudentManager
    {
        StudentGateway objStudentGateway = new StudentGateway();

        public bool isRegNoExists(string regNo)
        {
            return objStudentGateway.GetStudentByRegNo(regNo);
        }

        public int InsertStudent(MyStudent student)
        {
            return objStudentGateway.InsertStudent(student);
        }

        public int UpdateStudent(MyStudent student)
        {
            return objStudentGateway.UpdatetStudent(student);
        }

        public MyStudent GetStudentByID(int Id)
        {
            MyStudent student = objStudentGateway.GetStudentById(Id);

            return student;
        }
        public List<MyStudent> GetStudentByName(string name)
        {
            List<MyStudent> students = objStudentGateway.GetStudentsByName(name);

            return students;
        }
        public List<MyStudent> GetAllStudents()
        {
            List<MyStudent> students = objStudentGateway.GetAllStudents();

            return students;
        }
    }
}
