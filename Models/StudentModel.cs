using System;
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

//code from code example model
 [Display(Name = "First Name")]
public string FirstName { get; set; }

[Display(Name = "Last Name")]
public string LastName { get; set; }

[Display(Name = "Current Age")]
public int Age { get; set; } = 0;

[Display(Name = "Living Status")]
public bool IsAlive { get; set; } = true;

//new property 
[Display(Name = "My Link")]
public string myLink { get; set; };

    
    }
}
