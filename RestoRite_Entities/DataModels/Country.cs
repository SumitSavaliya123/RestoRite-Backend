using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Entities.Abstract;

namespace RestoRite_Entities.DataModels
{
    public class Country : IdentityEntity<int>
    {
        [StringLength(50)]
        public string CountryName { get; set; } = null!;
    }
}