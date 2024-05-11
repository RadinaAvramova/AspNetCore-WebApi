using Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MyApi.Models
{
    public class UserDto : IValidatableObject
    {
        [Required]
        [StringLength(100)]
        public string UserName { get; set; }

        [Required]
        [StringLength(100)]
        public string Email { get; set; }

        [Required]
        [StringLength(500)]
        public string Password { get; set; }

        [Required]
        [StringLength(100)]
        public string FullName { get; set; }

        public int Age { get; set; }

        public GenderType Gender { get; set; }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        {
            if (UserName.Equals("test", StringComparison.OrdinalIgnoreCase))
                yield return new ValidationResult("Username cannot be 'test'", new[] { nameof(UserName) });
            if (Password.Equals("123456"))
                yield return new ValidationResult("Password cannot be '123456'", new[] { nameof(Password) });
            if (Gender == GenderType.Male && Age > 30)
                yield return new ValidationResult("Males over 30 years old are not valid", new[] { nameof(Gender), nameof(Age) });
        }
    }
}

