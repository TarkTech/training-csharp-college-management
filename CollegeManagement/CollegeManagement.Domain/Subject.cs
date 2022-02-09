using System;
using System.ComponentModel.DataAnnotations;

namespace CollegeManagement.Domain
{
    public class Subject
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public int ObtainedMarks { get; set; }
        public int TotalMarks { get; set; }
    }
}