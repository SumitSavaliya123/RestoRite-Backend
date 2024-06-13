using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using Entities.Abstract;

namespace RestoRite_Entities.DataModels
{
    public class RestaurantBranch : AuditableEntity<int>
    {
        public int RestaurantId { get; set; }

        public int CountryId { get; set; }

        public int CityId { get; set; }

        public int OwnerId { get; set; }

        [StringLength(15)]
        public string PhoneNumber { get; set; } = null!;

        [StringLength(50)]
        public string Email { get; set; } = null!;

        [StringLength(500)]
        public string? Address { get; set; }

        [ForeignKey(nameof(CountryId))]
        public virtual Country Countries { get; set; } = null!;

        [ForeignKey(nameof(CityId))]
        public virtual City Cities { get; set; } = null!;

        [ForeignKey(nameof(OwnerId))]
        public virtual User Users { get; set; } = null!;

        [ForeignKey(nameof(RestaurantId))]
        public virtual Restaurant Restaurants { get; set; } = null!;
    }
}