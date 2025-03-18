using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Mission10_Cruz.Data
{
    public class BowlingCrew
    {
        // information for all the bowling crew
        [Key]
        public int BowlerId { get; set; }
        [Required]
        public string? BowlerFirstName { get; set; }
        
        public string? BowlerMiddleInit { get; set; }
        [Required]
        public string? BowlerLastName { get; set; }

        [Required]
        public string? BowlerAddress { get; set; }
        [Required]
        public string? BowlerCity { get; set; }
        [Required]
        public string? BowlerState { get; set; }
        [Required]
        public string? BowlerZip { get; set; }
        [Required]
        public string? BowlerPhoneNumber { get; set; }


        // Foreign Key for the team
        [ForeignKey("Team")]
        public int TeamId { get; set; }

        [Required]

    
        public Team? Team { get; set; }
    }
}
