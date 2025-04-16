using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Volo.Abp.Domain.Entities.Auditing;

namespace TaskTimeTracker.Entities;

public class TimeEntry : AuditedAggregateRoot<Guid>
{
    [Key]
    public Guid Id { get; set; }

    public DateTime Date { get; set; }

    public double Hours { get; set; }

    public string Notes { get; set; }

    public Guid TaskId { get; set; }

    [ForeignKey("TaskId")]
    public virtual Task Task { get; set; }

    public Guid UserId { get; set; }

    [ForeignKey("UserId")]
    public virtual User User { get; set; }
}
