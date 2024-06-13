using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using Entities.Abstract;

namespace RestoRite_Entities.DataModels
{
    public class Menu : AuditableEntity<int>
    {
        public int RestaurantBranchId { get; set; }

        [StringLength(20)]
        public string DishCategory { get; set; } = null!;

        [StringLength(50)]
        public string DishName { get; set; } = null!;

        public int Price { get; set; }

        public byte[] DishImage { get; set; } = null!;

        [StringLength(300)]
        public string ShortDescription { get; set; } = null!;

        [ForeignKey(nameof(RestaurantBranchId))]
        public virtual RestaurantBranch RestaurantBranches { get; set; } = null!;
    }
}