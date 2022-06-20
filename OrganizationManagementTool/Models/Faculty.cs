using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace OrganizationManagementTool.Models
{
    public class Faculty
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "Required")]
        [RegularExpression(@"^[a-zA-Z ]+$", ErrorMessage = "Only Alphabets are allowed")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Required")]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }

        [Required(ErrorMessage = "You must provide a phone number")]
        [Display(Name = "Mobile Number")]
        [DataType(DataType.PhoneNumber)]
        [RegularExpression(@"^\(?([0-9]{3})\)?[-. ]?([0-9]{3})[-. ]?([0-9]{4})$", ErrorMessage = "Not a valid phone number")]
        public string Mobile { get; set; }

        [Required(ErrorMessage = "Required")]
        public int Age { get; set; }

        [Required(ErrorMessage = "Please choose gender")]
        [StringLength(1, MinimumLength = 1, ErrorMessage = "The Gender must be 1 characters.")]
        [RegularExpression("M|F", ErrorMessage = "The Gender must be either 'M' or 'F' only.")]
        public string Gender { get; set; }

        [Required(ErrorMessage ="Required")]
        [Display(Name= "Department")]
        public int DeptId { get; set; }

        [NotMapped]
        public string DeptName { get; set; }
    }
}
