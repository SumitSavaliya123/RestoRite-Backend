using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using Entities.Abstract;

namespace RestoRite_Entities.DataModels
{
    public class City : IdentityEntity<int>
    {
        [StringLength(50)]
        public string CityName { get; set; } = null!;

        public int CountryId { get; set; }

        [ForeignKey(nameof(CountryId))]
        public virtual Country Countries { get; set; } = null!;
    }
}