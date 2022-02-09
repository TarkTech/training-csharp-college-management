using CollegeManagement.API.Dto;
using CollegeManagement.API.Service;
using CollegeManagement.Domain;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace CollegeManagement.API.Controllers
{
    [Route("colleges/{collegeId}/students")]
    [ApiController]
    public class StudentsController : ControllerBase
    {
        private readonly IStudentService _studentService;

        public StudentsController(IStudentService studentService)
        {
            _studentService = studentService;
        }

        [HttpGet]
        public ActionResult<List<Student>> GetAllStudents()
        {
            return Ok(_studentService.GetAllStudents());
        }

        [HttpGet("{id}", Name = "GetStudent")]
        public ActionResult<Student> GetStudent(long id)
        {
            var student = _studentService.GetStudent(id);

            if (student == null)
            {
                return NotFound();
            }

            return Ok(student);
        }

        [HttpPost]
        public ActionResult<StudentIdDto> CreateStudent(Student student)
        {
            _studentService.CreateStudent(student);
            var studentIdDto = new StudentIdDto() { Id = student.Id };
            return Ok(studentIdDto);
        }

        [HttpPut("{id}")]
        public IActionResult UpdateStudent(long id, Student student)
        {
            if (_studentService.GetStudent(id) == null)
            {
                return NotFound();
            }
            _studentService.UpdateStudent(id, student);
            return NoContent();
        }


        [HttpDelete("{id}")]
        public ActionResult<Student> DeleteStudent(long id)
        {
            var student = _studentService.GetStudent(id);

            if (student == null)
            {
                return NotFound();
            }

            _studentService.DeleteStudent(id);
            return NoContent();
        }
    }
}
