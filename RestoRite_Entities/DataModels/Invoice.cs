using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using Entities.Abstract;

namespace RestoRite_Entities.DataModels
{
    public class Invoice : AuditableEntity<int>
    {
        public int InvoiceNumber { get; set; }

        public int CustomerId { get; set; }

        public int RestaurantBranchId { get; set; }

        public int TotalAmount { get; set; }

        [StringLength(50)]
        public string PaymentMethod { get; set; } = null!;

        [StringLength(50)]
        public string PaymentStatus { get; set; } = null!;

        [ForeignKey(nameof(CustomerId))]
        public virtual User Users { get; set; } = null!;

        [ForeignKey(nameof(RestaurantBranchId))]
        public virtual RestaurantBranch RestaurantBranches { get; set; } = null!;
    }
}