using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
namespace CollegeManagement.Domain
{
    public class Semester
    {
        public long Id { get; set; }
        public int SemesterNo { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public long StudentId { get; set; }
        public List<Subject> Subjects { get; set; }

        public Semester()
        {
            Subjects = new List<Subject>();
        }

    }
}