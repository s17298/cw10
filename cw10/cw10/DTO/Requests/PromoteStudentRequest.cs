﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace cw10.DTOs.Requests
{
    public class PromoteStudentRequest
    {
        public string Studies { get; set; }
        public int Semester { get; set; }
    }
}
