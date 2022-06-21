using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace OrganizationManagementTool.Models
{
    public class FacultyModel
    {
        [Key]
        public int Id { get; set; }

        public string Name { get; set; }

        public string Email { get; set; }

        public string Mobile { get; set; }

        public int Age { get; set; }

        public string Gender { get; set; }

       // [ForeignKey("Id")]
        public int DeptId { get; set; }

        [NotMapped]
        public string DeptName { get; set; }
    }
}
