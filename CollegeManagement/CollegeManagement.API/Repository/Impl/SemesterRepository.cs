using CollegeManagement.Data;
using CollegeManagement.Domain;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CollegeManagement.API.Repository.Impl
{
    public class SemesterRepository : ISemesterRepository
    {
        private readonly CollegeManagementContext _collegeManagementContext;
        public SemesterRepository(CollegeManagementContext collegeManagementContext)
        {
            _collegeManagementContext = collegeManagementContext;
        }
        public List<Semester> GetAllSemesters()
        {
            return _collegeManagementContext.Semesters.Include(semester => semester.Subjects)
                                                      .AsNoTracking().ToList();
        }

        public Semester GetSemester(long id)
        {
            return _collegeManagementContext.Semesters.Include(semester => semester.Subjects)
                                                      .AsNoTracking().FirstOrDefault(semester => semester.Id == id);
        }

        public void CreateSemester(Semester semester)
        {
            _collegeManagementContext.Add(semester);
            _collegeManagementContext.SaveChanges();
        }

        public void UpdateSemester(long id, Semester semester)
        {
            _collegeManagementContext.Semesters.Update(semester);
            _collegeManagementContext.SaveChanges();
            
        }

        public void DeleteSemester(long id)
        {
            var semester = _collegeManagementContext.Semesters.Find(id);
            _collegeManagementContext.Semesters.Remove(semester);
            _collegeManagementContext.SaveChanges();
            
        }
    }
}