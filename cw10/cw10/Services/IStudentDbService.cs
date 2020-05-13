using cw10.DTOs.Requests;
using cw10.DTOs.Responses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace cw10.Services
{
    public interface IStudentDbService
    {
        public EnrollStudentResponse EnrollStudent(EnrollStudentRequest request);
        public PromoteStudentResponse PromoteStudents(PromoteStudentRequest request);

        public GetStudentResponse GetStudents();
        public void ModifyStudent(ModifyStudentRequest request);
        public void DeleteStudent(DeleteStudentRequest request);
    }
}
