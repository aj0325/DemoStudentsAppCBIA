using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Demo.Api.Domain.Entities;

[Table("cultural_events")]
public record CulturalEvent
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    [Column("id")]
    public int Id { get; init; }

    [Column("event_name")]
    [MaxLength(100)]
    public string? EventName { get; init; }

    [Column("event_date")]
    public DateTime Date { get; init; }

    [Column("event_description")]
    [MaxLength(500)]
    public string? Description { get; init; }

    [Column("signed_up")]
    public bool SignedUp { get; init; }
}
