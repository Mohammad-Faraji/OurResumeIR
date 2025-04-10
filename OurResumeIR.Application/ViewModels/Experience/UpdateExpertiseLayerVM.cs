﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OurResumeIR.Application.ViewModels.Experience
{
    public class UpdateExpertiseLayerVM
    {
        [Required(ErrorMessage = "نام را وارد کنید")]
        [Display(Name = "نام را وارد کنید")]
        public string Name { get; set; }
        public int Id { get; set; }
    }
}
