using CollegeManagement.Domain;
using System;
using System.Collections.Generic;

namespace CollegeManagement.API.Repository
{
    public interface ISubjectRepository
    {
        List<Subject> GetAllSubjects();
        Subject GetSubject(long id);
        void CreateSubject(Subject subject);
        void DeleteSubject(long id);
        void UpdateSubject(long id, Subject subject);
    }
}