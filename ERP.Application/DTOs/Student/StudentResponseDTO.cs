using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ERP.Application.DTOs.Student
{
    /// <summary>
    /// Minimal DTO to satisfy references to StudentResponseDTO.
    /// Add properties here that represent the student response payload.
    /// </summary>
    public class StudentResponseDTO
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
}
