using CollegeManagement.Data;
using CollegeManagement.Domain;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CollegeManagement.API.Repository.Impl
{
    public class SubjectRepository : ISubjectRepository
    {
        private readonly CollegeManagementContext _collegeManagementContext;
        public SubjectRepository(CollegeManagementContext collegeManagementContext)
        {
            _collegeManagementContext = collegeManagementContext;
        }

        public List<Subject> GetAllSubjects()
        {
            return _collegeManagementContext.Subjects.AsNoTracking().ToList();
        }

        public Subject GetSubject(long id)
        {
            return _collegeManagementContext.Subjects.AsNoTracking().FirstOrDefault(subject => subject.Id == id);
        }

        public void CreateSubject(Subject subject)
        {
            _collegeManagementContext.Subjects.Add(subject);
            _collegeManagementContext.SaveChanges();
            
        }

        public void UpdateSubject(long id, Subject subject)
        {
            _collegeManagementContext.Subjects.Update(subject);
            _collegeManagementContext.SaveChanges();
            
        }

        public void DeleteSubject(long id)
        {
            var subject = _collegeManagementContext.Subjects.Find(id);
            _collegeManagementContext.Subjects.Remove(subject);
            _collegeManagementContext.SaveChanges();
            
        }
    }
}
