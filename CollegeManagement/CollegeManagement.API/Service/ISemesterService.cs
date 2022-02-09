using CollegeManagement.Domain;
using System;
using System.Collections.Generic;

namespace CollegeManagement.API.Service
{
    public interface ISemesterService
    {
        List<Semester> GetAllSemesters();
        Semester GetSemester(long id);
        void CreateSemester(Semester semester);
        void DeleteSemester(long id);
        void UpdateSemester(long id, Semester semester);
    }
}