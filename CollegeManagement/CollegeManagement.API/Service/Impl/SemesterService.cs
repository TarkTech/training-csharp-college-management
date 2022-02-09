using CollegeManagement.API.Repository;
using CollegeManagement.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CollegeManagement.API.Service.Impl
{
    public class SemesterService : ISemesterService
    {
        private readonly ISemesterRepository _semesterRepository;

        public SemesterService(ISemesterRepository semesterRepository)
        {
            _semesterRepository = semesterRepository;
        }

        public List<Semester> GetAllSemesters()
        {
            return _semesterRepository.GetAllSemesters();
        }

        public Semester GetSemester(long id)
        {
            return _semesterRepository.GetSemester(id);
        }

        public void CreateSemester(Semester semester)
        {
            _semesterRepository.CreateSemester(semester);
            
        }

        public void UpdateSemester(long id, Semester semester)
        {
            _semesterRepository.UpdateSemester(id, semester);
            
        }

        public void DeleteSemester(long id)
        {
            _semesterRepository.DeleteSemester(id);
            
        }
    }
}
