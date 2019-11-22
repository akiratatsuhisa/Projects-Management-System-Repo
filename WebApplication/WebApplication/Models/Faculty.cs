﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication.Models
{
    public class Faculty
    {
        public short Id { get; set; }

        [Required]
        [StringLength(256)]
        public string Name { get; set; }

        public virtual ICollection<SpecializedFaculty> SpecializedFaculties { get; set; }
   
        public virtual ICollection<Student> Students { get; set; }
        
        public virtual ICollection<Lecturer> Lecturers { get; set; }
    }
}
