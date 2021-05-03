using System;
using System.Collections.Generic;
using System.Text;

namespace Logic_Layer.Models
{
    public static class DTOMappers
    {
        public static List<Student> MapStudent(List<Database_Layer.Models.Student> students)
        {
            List<Student> mappedStudents = new List<Student>();

            foreach (Database_Layer.Models.Student student in students)
            {
                mappedStudents.Add(new Student()
                {
                    Id = student.Id,
                    Name = student.Name,
                    AvailableSlots = student.AvailableSlots
                });
            }

            return mappedStudents;
        }

    }
}
