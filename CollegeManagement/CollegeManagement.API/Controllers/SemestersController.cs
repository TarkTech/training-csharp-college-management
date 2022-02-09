using CollegeManagement.API.Dto;
using CollegeManagement.API.Service;
using CollegeManagement.Domain;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace CollegeManagement.API.Controllers
{
    [Route("colleges/{collegeId}/students/{studentId}/semesters")]
    [ApiController]
    public class SemestersController : ControllerBase
    {
        private readonly ISemesterService _semesterService;

        public SemestersController(ISemesterService semesterService)
        {
            _semesterService = semesterService;
        }

        [HttpGet]
        public ActionResult<List<Semester>> GetAllSemesters()
        {
            return Ok(_semesterService.GetAllSemesters());
        }

        [HttpGet("{id}", Name = "GetSemester")]
        public ActionResult<Semester> GetSemester(long id)
        {
            var semester = _semesterService.GetSemester(id);

            if (semester == null)
            {
                return NotFound();
            }

            return Ok(semester);
        }

        [HttpPost]
        public ActionResult<SemesterIdDto> CreateSemester(Semester semester)
        {
            _semesterService.CreateSemester(semester);
            var semesterIdDto = new SemesterIdDto() { Id = semester.Id };
            return Ok(semesterIdDto);
        }

        [HttpPut("{id}")]
        public IActionResult UpdateSemester(long id, Semester semester)
        {
            if (_semesterService.GetSemester(id) == null)
            {
                return NotFound();
            }

            _semesterService.UpdateSemester(id, semester);
            return NoContent();
        }

        [HttpDelete("{id}")]
        public ActionResult<Semester> DeleteSemester(long id)
        {
            var semester = _semesterService.GetSemester(id);

            if (semester == null)
            {
                return NotFound();
            }

            _semesterService.DeleteSemester(id);
            return NoContent();
        }
    }
}
