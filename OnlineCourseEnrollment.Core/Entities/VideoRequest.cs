using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace OnlineCourseEnrollment.Core.Entities;

[Table("VideoRequest")]
public partial class VideoRequest
{
    [Key]
    public int VideoRequestId { get; set; }

    public int UserId { get; set; }

    [StringLength(50)]
    public string Topic { get; set; } = null!;

    [StringLength(50)]
    public string SubTopic { get; set; } = null!;

    [StringLength(200)]
    public string ShortTitle { get; set; } = null!;

    [StringLength(4000)]
    public string RequestDescription { get; set; } = null!;

    [StringLength(4000)]
    public string? Response { get; set; }

    [StringLength(2000)]
    public string? VideoUrls { get; set; }

    [ForeignKey("UserId")]
    [InverseProperty("VideoRequests")]
    public virtual UserProfile User { get; set; } = null!;
}
