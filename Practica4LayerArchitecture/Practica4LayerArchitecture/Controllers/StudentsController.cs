﻿using Logic_Layer.Managers;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using Logic_Layer.Models;
using Logic_Layer.Managers;

namespace Practica4LayerArchitecture.Controllers
{
    [ApiController]
    [Route("[/api/students]")]
    public class StudentsController : ControllerBase
    {
        private readonly StudentManager _studentManager;
        public StudentsController()
        {
            _studentManager = new StudentManager();
        }

        [HttpPost]
        public Student CreatePerson([FromBody] string studentName) // a. Create User
        {
            return _studentManager.CreatePerson(studentName);
        }

        [HttpPut]
        public Student UpdateStudent([FromBody] Student student) // b. Update User
        {
            return _studentManager.UpdateStudent(student);
        }

        [HttpDelete]
        public Student DeletePerson([FromBody] Student student) // c. Delete User
        {
            return _studentManager.DeletePerson(student);
        }

        [HttpGet]
        public List<Student> GetStudents() // d. Get User
        {
            return _studentManager.GetAllStudents();
        }

    }
}
