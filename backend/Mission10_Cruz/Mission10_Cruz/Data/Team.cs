using System.ComponentModel.DataAnnotations;

namespace Mission10_Cruz.Data
{
    public class Team
    {
        [Key]
        //primary key
        public int TeamId { get; set; } 

        [Required]
        public string? TeamName { get; set; }

    }
}
