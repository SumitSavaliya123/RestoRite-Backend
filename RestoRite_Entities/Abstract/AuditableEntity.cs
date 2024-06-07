﻿using RestoRite_Entities.DataModels;
using System.ComponentModel.DataAnnotations.Schema;

namespace Entities.Abstract;
public abstract class AuditableEntity<T> : IdentityEntity<T>
{
    public int CreatedBy { get; set; }

    public int? UpdatedBy { get; set; }

    [ForeignKey(nameof(CreatedBy))]
    public virtual User CreatedByUser { get; set; } = null!;

    [ForeignKey(nameof(UpdatedBy))]
    public virtual User? UpdatedByUser { get; set; } = null!;

    public virtual DateTimeOffset CreatedOn { get; set; } = DateTimeOffset.UtcNow;

    public virtual DateTimeOffset? UpdatedOn { get; set; }

    public virtual DateTimeOffset? DeletedOn { get; set; }
}
