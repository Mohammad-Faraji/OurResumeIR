﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OurResumeIR.Domain.Models
{
    public class MyExperiences
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string UserId { get; set; }

        // Navigation Property
        public User User { get; set; }
    }
}
