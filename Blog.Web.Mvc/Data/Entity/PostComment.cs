﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Blog.Web.Mvc.Data.Entity;

public class PostComment
{
    [Key]
    public int Id { get; set; }
    public int PostId { get; set; }
    public int UserId { get; set; }


    [Column(TypeName = "text")]
    public string? Comment { get; set; }

    public bool IsActive { get; set; }
}
