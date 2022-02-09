using CollegeManagement.Data;
using CollegeManagement.Domain;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;

namespace CollegeManagement.API.Repository.Impl
{
    public class CollegeRepository : ICollegeRepository
    {
        private readonly CollegeManagementContext _collegeManagementContext;
        public CollegeRepository(CollegeManagementContext collegeManagementContext)
        {
            _collegeManagementContext = collegeManagementContext;
        }

        public List<College> GetAllColleges()
        {
            return _collegeManagementContext.Colleges.Include(college => college.Students)
                                                     .ThenInclude(student => student.Semesters)
                                                     .ThenInclude(semester => semester.Subjects)
                                                     .AsNoTracking().ToList();
        }

        public College GetCollege(long id)
        {
            return _collegeManagementContext.Colleges.Include(college => college.Students)
                                                     .ThenInclude(student => student.Semesters)
                                                     .ThenInclude(semester => semester.Subjects)
                                                     .AsNoTracking().FirstOrDefault(college => college.Id == id);
        }

        public void CreateCollege(College college)
        {
            _collegeManagementContext.Colleges.Add(college);
            _collegeManagementContext.SaveChanges();
        }

        public void UpdateCollege(long id, College college)
        {
            _collegeManagementContext.Colleges.Update(college);
            _collegeManagementContext.SaveChanges();
        }

        public void DeleteCollege(long id)
        {
            var college = _collegeManagementContext.Colleges.Find(id);
            _collegeManagementContext.Colleges.Remove(college);
            _collegeManagementContext.SaveChanges();
            
        }

    }
}
