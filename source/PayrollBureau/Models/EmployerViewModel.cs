﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using PayrollBureau.Data.Entities;

namespace PayrollBureau.Models
{
    public class EmployerViewModel
    {
        public Employer Employer { get; set; }
        public int EmployerId { get; set; }
    }
}