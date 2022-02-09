using CollegeManagement.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CollegeManagement.API.Repository
{
    public interface IStudentRepository
    {
        void CreateStudent(Student student);
        void UpdateStudent(long id, Student student);
        void DeleteStudent(long id);
        List<Student> GetAllStudents();
        Student GetStudent(long id);
    }
}
