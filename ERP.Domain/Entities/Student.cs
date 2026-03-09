using ERP.Domain.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ERP.Domain.Entities
{
    [Table("TblAdmStudentsMaster")]
    public class Student : AuditableEntity
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string EnrollmentNo { get; set; }
        public int AdminStatus { get; set; }

    }
}
