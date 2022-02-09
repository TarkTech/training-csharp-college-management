using CollegeManagement.Data;
using CollegeManagement.Domain;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CollegeManagement.API.Repository.Impl
{
    public class StudentRepository : IStudentRepository
    {
        private readonly CollegeManagementContext _collegeManagementContext;
        public StudentRepository(CollegeManagementContext collegeManagementContext)
        {
            _collegeManagementContext = collegeManagementContext;
        }

        public List<Student> GetAllStudents()
        {
            return _collegeManagementContext.Students.Include(student => student.Semesters)
                                                     .ThenInclude(semester => semester.Subjects)
                                                     .AsNoTracking().ToList();
        }

        public Student GetStudent(long id)
        {
            return _collegeManagementContext.Students.Include(student => student.Semesters)
                                                     .ThenInclude(semester => semester.Subjects)
                                                     .AsNoTracking().FirstOrDefault(student => student.Id == id);
        }

        public void CreateStudent(Student student)
        {
            _collegeManagementContext.Students.Add(student);
            _collegeManagementContext.SaveChanges();
        }

        public void UpdateStudent(long id, Student student)
        {
            _collegeManagementContext.Students.Update(student);
            _collegeManagementContext.SaveChanges();
            
        }

        public void DeleteStudent(long id)
        {
            var student = _collegeManagementContext.Students.Find(id);
            _collegeManagementContext.Students.Remove(student);
            _collegeManagementContext.SaveChanges();
        }

    }
}
