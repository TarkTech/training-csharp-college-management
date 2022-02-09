using CollegeManagement.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CollegeManagement.API.Service
{
    public interface IStudentService
    {
        List<Student> GetAllStudents();
        Student GetStudent(long id);
        void CreateStudent(Student student);
        void UpdateStudent(long id, Student student);
        void DeleteStudent(long id);

    }
}
