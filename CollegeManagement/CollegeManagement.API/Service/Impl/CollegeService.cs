using CollegeManagement.API.Repository;
using CollegeManagement.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CollegeManagement.API.Service.Impl
{
    public class CollegeService : ICollegeService
    {
        private readonly ICollegeRepository _collegeRepository;
        public CollegeService(ICollegeRepository collegeRepository)
        {
            _collegeRepository = collegeRepository;
        }
        public void CreateCollege(College college)
        {
            _collegeRepository.CreateCollege(college);
        }
        public void UpdateCollege(long id, College college)
        {
            _collegeRepository.UpdateCollege(id, college);
        }

        public void DeleteCollege(long id)
        {
            _collegeRepository.DeleteCollege(id);
            
        }

        public List<College> GetAllColleges()
        {
            return _collegeRepository.GetAllColleges();
        }

        public College GetCollege(long id)
        {
           return _collegeRepository.GetCollege(id);
        }
    }
}
