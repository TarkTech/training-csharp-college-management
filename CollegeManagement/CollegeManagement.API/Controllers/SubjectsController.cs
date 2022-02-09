using CollegeManagement.API.Dto;
using CollegeManagement.API.Service;
using CollegeManagement.Domain;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace CollegeManagement.API.Controllers
{
    [Route("colleges/{collegeId}/students/{studentId}/semesters/{semesterId}/subjects")]
    [ApiController]
    public class SubjectsController : ControllerBase
    {
        private readonly ISubjectService _subjectService;

        public SubjectsController(ISubjectService subjectService)
        {
            _subjectService = subjectService;
        }

        [HttpGet]
        public ActionResult<List<Subject>> GetAllSubjects()
        {
            return Ok(_subjectService.GetAllSubjects());
        }

        [HttpGet("{id}", Name = "GetSubject")]
        public ActionResult<Subject> GetSubject(long id)
        {
            var subject = _subjectService.GetSubject(id);

            if (subject == null)
            {
                return NotFound();
            }

            return Ok(subject);
        }

        [HttpPost]
        public ActionResult<SubjectIdDto> CreateSubject(Subject subject)
        {
            _subjectService.CreateSubject(subject);
            var subjectIdDto = new SubjectIdDto() { Id = subject.Id };
            return Ok(subjectIdDto);
        }

        [HttpPut("{id}")]
        public IActionResult UpdateSubject(long id, Subject subject)
        {
            if (_subjectService.GetSubject(id) == null)
            {
                return NotFound();
            }

            _subjectService.UpdateSubject(id, subject);

            return NoContent();
        }

        [HttpDelete("{id}")]
        public ActionResult<Subject> DeleteSubject(long id)
        {
            var subject = _subjectService.GetSubject(id);

            if (subject == null)
            {
                return NotFound();
            }

            _subjectService.DeleteSubject(id);
            return NoContent();
        }
    }
}
