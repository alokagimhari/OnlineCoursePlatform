using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace OnlineCourseEnrollment.Core.Entities;

public partial class SessionDetail
{
    [Key]
    public int SessionId { get; set; }

    public int CourseId { get; set; }

    [StringLength(100)]
    public string Title { get; set; } = null!;

    public string? Description { get; set; }

    [StringLength(500)]
    public string? VideoUrl { get; set; }

    public int VideoOrder { get; set; }

    [ForeignKey("CourseId")]
    [InverseProperty("SessionDetails")]
    public virtual Course Course { get; set; } = null!;
}
