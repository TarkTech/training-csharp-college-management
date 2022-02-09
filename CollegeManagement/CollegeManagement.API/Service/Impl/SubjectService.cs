using CollegeManagement.API.Repository;
using CollegeManagement.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CollegeManagement.API.Service.Impl
{
    public class SubjectService : ISubjectService
    {
        private readonly ISubjectRepository _subjectRepository;

        public SubjectService(ISubjectRepository subjectRepository)
        {
            _subjectRepository = subjectRepository;
        }

        public List<Subject> GetAllSubjects()
        {
            return _subjectRepository.GetAllSubjects();
        }

        public Subject GetSubject(long id)
        {
            return _subjectRepository.GetSubject(id);
        }

        public void CreateSubject(Subject subject)
        {
            _subjectRepository.CreateSubject(subject);
            
        }

        public void UpdateSubject(long id, Subject subject)
        {
            _subjectRepository.UpdateSubject(id, subject);
            
        }

        public void DeleteSubject(long id)
        {
            _subjectRepository.DeleteSubject(id);
            
        }
    }
}
