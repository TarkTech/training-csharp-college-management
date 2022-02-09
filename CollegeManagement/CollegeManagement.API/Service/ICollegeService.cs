using CollegeManagement.API.Repository;
using CollegeManagement.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CollegeManagement.API.Service
{
    public interface ICollegeService
    {
        List<College> GetAllColleges();
        College GetCollege(long id);
        void CreateCollege(College college);
        void DeleteCollege(long id);
        void UpdateCollege(long id, College college);
    }
}
