using CollegeManagement.Domain;
using System;
using System.Collections.Generic;

namespace CollegeManagement.API.Service
{
    public interface ISubjectService
    {
        List<Subject> GetAllSubjects();
        Subject GetSubject(long id);
        void CreateSubject(Subject subject);
        void UpdateSubject(long id, Subject subject);
        void DeleteSubject(long id);
    }
}