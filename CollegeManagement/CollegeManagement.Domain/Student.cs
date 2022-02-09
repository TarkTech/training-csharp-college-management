using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace CollegeManagement.Domain
{
    public class Student
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public string EnrollmentNo { get; set; }
        public string MobileNo { get; set; }
        public string Email { get; set; }
        public long CollegeId { get; set; }
        public List<Semester> Semesters { get; set; }

        public Student()
        {
            Semesters = new List<Semester>();
        }
    }
}