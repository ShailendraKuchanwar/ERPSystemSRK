using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ERP.Application.DTOs.Student;

namespace ERP.Domain.Interfaces
{
    public interface IStudentService
    {
        Task<List<StudentResponseDTO>> GetAllStudents();
        Task<string> CreateStudent(StudentCreateDTO dto);
    }
}
