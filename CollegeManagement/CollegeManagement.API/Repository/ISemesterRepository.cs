using CollegeManagement.Domain;
using System;
using System.Collections.Generic;

namespace CollegeManagement.API.Repository
{
    public interface ISemesterRepository
    {
        List<Semester> GetAllSemesters();
        Semester GetSemester(long id);
        void CreateSemester(Semester semester);
        void UpdateSemester(long id, Semester semester);
        void DeleteSemester(long id);
    }
}