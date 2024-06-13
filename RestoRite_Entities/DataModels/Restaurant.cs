using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Entities.Abstract;

namespace RestoRite_Entities.DataModels
{
    public class Restaurant : AuditableEntity<int>
    {
        [StringLength(50)]
        public string Name { get; set; } = null!;

        public byte[] Logo { get; set; } = null!;

        [StringLength(50)]
        public string Email { get; set; } = null!;

        [MaxLength(100)]
        public string Title { get; set; } = null!;

        [MaxLength(500)]
        public string? Descrption { get; set; }

        [StringLength(15)]
        public string PhoneNumber { get; set; } = null!;
    }
}