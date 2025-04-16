using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Volo.Abp.Domain.Entities.Auditing;

namespace TaskTimeTracker.Entities;

public class Project : AuditedAggregateRoot<Guid>
{
    [Key]
    public Guid Id { get; set; }

    [Required]
    [StringLength(256)]
    public string Name { get; set; }

    public string Description { get; set; }

    public Guid UserId { get; set; }

    [ForeignKey("UserId")]
    public virtual User User { get; set; }
}
