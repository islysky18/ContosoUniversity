using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ContosoUniversity.Models
{
    public class Student
    {
        public int ID { get; set; }
        public string LastName { get; set; }
        public string FirstMidName { get; set; }
        public DateTime EnrollmentDate { get; set; }

        //Enrollments : navigation property
        //  Navigation properties hold other entities that are related to this entity. 
        //In this case, the Enrollments property of a Student entity will hold all of the Enrollment entities that are related to that Student entity
        public virtual ICollection<Enrollment> Enrollments { get; set; }
    }
}