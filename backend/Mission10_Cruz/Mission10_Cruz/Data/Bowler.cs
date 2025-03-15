using System.ComponentModel.DataAnnotations;

namespace Mission10_Cruz.Data;

    public class Bowler
    {
        [Key]
        public int BowlerID { get; set; }

        [Required]
        public string BowlerLastName { get; set; }

        public string BowlerFirstName { get; set; }
        public string BowlerMiddleInit { get; set; }
        public string BowlerAddress { get; set; }
        public string BowlerCity { get; set; }
        public string BowlerState { get; set; }
    
        [Required]
        public string BowlerZip { get; set; }  // Zip codes should be strings
    
        public string BowlerPhoneNumber { get; set; }  // Phone numbers should be strings
    
        public int TeamID { get; set; }  // Foreign Key reference to Team table
    }


    