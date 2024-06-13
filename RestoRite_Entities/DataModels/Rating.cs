using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Entities.Abstract;

namespace RestoRite_Entities.DataModels
{
    public class Rating : IdentityEntity<int>
    {
        public int Value { get; set; }

        [StringLength(100)]
        public string? Text { get; set; }
    }
}