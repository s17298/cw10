using cw10.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace cw10.DTOs.Responses
{
    public class PromoteStudentResponse
    {
        public List<Student> students { get; set; }
    }
}
