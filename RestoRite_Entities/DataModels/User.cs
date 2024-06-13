using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using Entities.Abstract;
using RestoRite_Common.Enums;

namespace RestoRite_Entities.DataModels
{
    public class User : AuditableEntity<int>
    {
        [StringLength(50)]
        public string FirstName { get; set; } = null!;

        [StringLength(50)]
        public string LastName { get; set; } = null!;

        [StringLength(50)]
        public string Email { get; set; } = null!;

        [MaxLength(255)]
        public string Password { get; set; } = null!;

        [StringLength(10)]
        public string? OTP { get; set; }

        [StringLength(15)]
        public string PhoneNumber { get; set; } = null!;

        public byte[]? Avatar { get; set; }

        public UserRole Role { get; set; }

    }
}