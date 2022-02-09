using CollegeManagement.API.Repository;
using CollegeManagement.Domain;
using System.Collections.Generic;

namespace CollegeManagement.API.Service.Impl
{
    public class StudentService : IStudentService
    {
        private readonly IStudentRepository _studentRepository;
        public StudentService(IStudentRepository studentRepository)
        {
            _studentRepository = studentRepository;
        }
        public void CreateStudent(Student student)
        {
            _studentRepository.CreateStudent(student);
        }
        public void UpdateStudent(long id, Student student)
        {
            _studentRepository.UpdateStudent(id, student);
        }
        public void DeleteStudent(long id)
        {
            _studentRepository.DeleteStudent(id);
        }
        public List<Student> GetAllStudents()
        {
            return _studentRepository.GetAllStudents();
        }
        public Student GetStudent(long id)
        {
            return _studentRepository.GetStudent(id);
        }
    }
}
