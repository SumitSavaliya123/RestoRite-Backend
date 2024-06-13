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
    public class Order : AuditableEntity<int>
    {
        public int CustomerId { get; set; }

        public int RestaurantBranchId { get; set; }

        public int MenuId { get; set; }

        public int Quantity { get; set; }

        public int Price { get; set; }

        public DateTime? OrderTime { get; set; }

        [StringLength(20)]
        public OrderStatus Status { get; set; }

        [ForeignKey(nameof(CustomerId))]
        public virtual User User { get; set; } = null!;

        [ForeignKey(nameof(RestaurantBranchId))]
        public virtual RestaurantBranch RestaurantBranch { get; set; } = null!;

        [ForeignKey(nameof(MenuId))]
        public virtual Menu Menu { get; set; } = null!;
    }
}