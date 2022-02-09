using CollegeManagement.API.Dto;
using CollegeManagement.API.Service;
using CollegeManagement.Domain;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace CollegeManagement.API.Controllers
{
    [Route("colleges")]
    [ApiController]
    public class CollegesController : ControllerBase
    {
        private readonly ICollegeService _collegeService;

        public CollegesController(ICollegeService collegeService)
        {
            _collegeService = collegeService;
        }

        [HttpGet]
        public ActionResult<List<College>> GetAllColleges()
        {
            return Ok(_collegeService.GetAllColleges());
        }

        [HttpGet("{id}", Name = "GetCollege")]
        public ActionResult<College> GetCollege(long id)
        {
            var college = _collegeService.GetCollege(id);

            if (college == null)
            {
                return NotFound();
            }

            return Ok(college);
        }

        [HttpPost]
        public ActionResult<CollegeIdDto> CreateCollege(College college)
        {
            _collegeService.CreateCollege(college);
            var collegeIdDto = new CollegeIdDto() { Id = college.Id };
            return Ok(collegeIdDto);
        }

        [HttpPut("{id}")]
        public IActionResult UpdateCollege(long id, College college)
        {
            if (_collegeService.GetCollege(id) == null)
            {
                return NotFound();
            }
            _collegeService.UpdateCollege(id, college);

            return NoContent();
        }


        [HttpDelete("{id}")]
        public ActionResult<College> DeleteCollege(long id)
        {
            var college = _collegeService.GetCollege(id);

            if (college == null)
            {
                return NotFound();
            }

            _collegeService.DeleteCollege(id);

            return NoContent();
        }
    }
}
