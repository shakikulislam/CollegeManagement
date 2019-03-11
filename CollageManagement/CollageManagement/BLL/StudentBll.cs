using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CollageManagement.DAL;
using CollageManagement.Models;

namespace CollageManagement.BLL
{
    public class StudentBll
    {
        StudentDal studentDal=new StudentDal();
        public bool Add(Student student)
        {
            bool isFind = studentDal.CheckUnique(student);
            if (isFind)
            {
                throw new Exception("Student allready added...");
            }
            bool isSuccess = studentDal.AddStudent(student);
            if (isSuccess)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
