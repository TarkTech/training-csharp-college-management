using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace CollegeManagement.Domain
{
    public class College
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public string City { get; set; }
        public List<Student> Students { get; set; }

        public College()
        {
            Students = new List<Student>();
        }
    }
}
