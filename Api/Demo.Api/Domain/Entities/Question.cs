using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Demo.Api.Domain.Entities;

[Table("questions")]
public record Question
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    [Column("question_id")]
    public int Id { get; init; }

    [Column("student_id")]
    public int StudentId { get; init; }

    [Column("question")]
    [MaxLength(500)]
    public string? QuestionAsked { get; init; }

    [Column("asked_date")]
    public DateTime Date { get; init; }

    [Column("answer")]
    [MaxLength(500)]
    public string? Answer { get; init; }

    [Column("solved")]
    public bool Solved { get; init; }
}

