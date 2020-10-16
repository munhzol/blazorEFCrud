﻿using System;
using System.ComponentModel.DataAnnotations;

namespace BlazorEFTest.Data
{
    public class EmployeeInfo
    {
        [Key]
        public int EmployeeId { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        public string City { get; set; }

        [Required]
        public string Country { get; set; }

        [Required]
        public string Gender { get; set; }

    }
}
