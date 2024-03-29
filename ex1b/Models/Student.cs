﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ex1b.Models
{
    public class Student : Person
    {
        //private string lastName;

        //public int ID { get; set; }
        ////public string LastName { get; set; }

        //[Required]
        //[StringLength(50)]
        //[Display(Name = "Last Name")]
        //public string LastName { get; set; }

        //[Required]
        //[StringLength(50, ErrorMessage = "First name cannot be longer than 50 characters.")]
        //[Column("FirstName")]
        //[Display(Name = "First Name")]
        //public string FirstMidName { get; set; }
        //[Display(Name = "Full Name")]
        //public string FullName
        //{
        //    get
        //    {
        //        return LastName + ", " + FirstMidName;
        //    }
        //}
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        [Display(Name = "Enrollment Date")]
        public DateTime EnrollmentDate { get; set; }



        public ICollection<Enrollment> Enrollments { get; set; }
    }
}
