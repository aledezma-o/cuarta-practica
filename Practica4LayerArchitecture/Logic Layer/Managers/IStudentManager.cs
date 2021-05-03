using Logic_Layer.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Logic_Layer.Managers
{
    public interface IStudentManager
    {
        List<Student> GetAllStudents();
        Student CreatePerson(Student student);
        Student UpdateStudent(Student student);
        Student DeletePerson(Student student);
    }
}
