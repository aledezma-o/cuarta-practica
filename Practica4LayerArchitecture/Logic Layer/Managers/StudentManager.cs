using System;
using System.Collections.Generic;
using System.Text;
using Logic_Layer.Models;
using Database_Layer; 

namespace Logic_Layer.Managers
{
    public class StudentManager
    {
        
        private readonly DbContext _dbContext;
        public StudentManager()
        {
            _dbContext = new DbContext();
        }
        public List<Student> GetAllStudents()
        {
            List<Database_Layer.Models.Student> students = _dbContext.GetAll();
            return students;
        }

        public Student CreatePerson(string studentName) // a. Create User
        {
            return new Student()
            {
                Name = studentName
            };
        }

        public Student UpdateStudent(Student student) // b. Update User
        {
            student.Name = "updated";
            return student;
        }

        public Student DeletePerson(Student student) // c. Delete User
        {
            student.Name = "deleted";
            return student;
        }
    }
}
