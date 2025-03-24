using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Mission10_Cruz.Models;

public partial class Team
{
    [Required]
    public int TeamId { get; set; }

    [Required]
    public string TeamName { get; set; } = null!;

    public int? CaptainId { get; set; }

}
