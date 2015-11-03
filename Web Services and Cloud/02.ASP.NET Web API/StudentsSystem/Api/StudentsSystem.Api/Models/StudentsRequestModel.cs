using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace StudentsSystem.Api.Models
{
    public class StudentsRequestModel
    {
        [Required]
        [MaxLength(20)]
        [MinLength(3)]
        public string FirstName { get; set; }

        [Required]
        [MaxLength(20)]
        [MinLength(3)]
        public string LastName { get; set; }  
       
        
        public int Level { get; set; }
    }
}