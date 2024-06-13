using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using Entities.Abstract;

namespace RestoRite_Entities.DataModels
{
    public class Ingredient : AuditableEntity<int>
    {
        [StringLength(50)]
        public string Name { get; set; } = null!;

        [MaxLength(500)]
        public string? Description { get; set; }

        [Range(0, int.MaxValue)]
        public int Quantity { get; set; }

        [Range(0, int.MaxValue)]
        public int Price { get; set; }

        public int RestaurantBranchId { get; set; }

        [ForeignKey(nameof(RestaurantBranchId))]
        public virtual RestaurantBranch RestaurantBranches { get; set; } = null!;
    }
}