using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Adminpro.Models
{
    public class Student
    {
        [Key]

        public string RollNumber { get; set; }
        [Required(ErrorMessage = "Field can't be empty")]
        public string FirstName { get; set; }
        [Required(ErrorMessage = "Field can't be empty")]
        public string LastName { get; set; }
        [Required(ErrorMessage = "Field can't be empty")]
        public string Phone { get; set; }
        [Required(ErrorMessage = "Field can't be empty")]
        [DataType(DataType.EmailAddress, ErrorMessage = "E-mail is not valid")]
        public string Email { get; set; }
        [Required(ErrorMessage = "Field can't be empty")]
        public DateTime Birthday { get; set; }
        [Required(ErrorMessage = "Field can't be empty")]
        public Gender Gender { get; set; }
        public DateTime CreateAt { get; set; }
        public DateTime UpdateAt { get; set; }
        public StudentStatus Status { get; set; }

        public Student() {
            this.CreateAt = DateTime.Now;
            this.UpdateAt = DateTime.Now;
            this.Gender = Gender.Male;
            this.Status = StudentStatus.Activated;
            }

    }
    public enum Gender
    {
        Male = 1,
        Female = 0,
        Orther = 2
    }
    public enum StudentStatus
    {
        Activated = 1,
        Deactivated = 0
    }
}
