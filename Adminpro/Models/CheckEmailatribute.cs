using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Adminpro.Models
{
    public class CheckEmailatribute : ValidationAttribute
    {
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            Student st = (Student)validationContext.ObjectInstance;
            string email = value as string;
            if (st.Email.Contains("ABCD"))
            {
                return new ValidationResult("cant create", new[] { "Email" });
            }
            return ValidationResult.Success;
        }
    }
}
