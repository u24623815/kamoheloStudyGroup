﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Prac1.Models
{
	public class StudentModel
	{
		[Display (Name = "STUDENT NUMBER")]//  add as a decorater
		public string StudentNumber { get; set; }

        [Display(Name = "NAME")] //Add as decorator
        public string Name { get; set; }

        [Display(Name = "SURNAME")]//  add as a decorater
        public string Surname { get; set; }

        [Display(Name = "EMAIL ADDRESS")]//  add as a decorater
        public string Email{ get; set; }
    }
}
