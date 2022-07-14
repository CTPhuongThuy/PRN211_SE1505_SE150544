using System.ComponentModel.DataAnnotations;

#nullable disable

namespace DataAccess.DataAccess
{
    public partial class Employee
    {
        public string EmployeeId { get; set; }
        [Required]
        [MaxLength(12, ErrorMessage = "Max Length of Tour Name is 12")]
        [MinLength(6, ErrorMessage = " Min Length of Tour Name is 6")]
        public string FullName { get; set; }
        [Required]
        //[MinLength(7, ErrorMessage = " Min Length of Tour Name is 7")]
        public int? YearOfBirth { get; set; }
        [Required]
        public string JobTitle { get; set; }
        [Required]
        public string DepartmentId { get; set; }
        [Required]

        public virtual Department Department { get; set; }
    }
}
