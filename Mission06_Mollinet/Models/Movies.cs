using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations; 


namespace Mission06_Mollinet.Models
{
    public class Movies
    {
        [Key]
        [Required]
        public int MovieId { get; set; }

        [ForeignKey("CategoryId")]
        public int? CategoryId { get; set; }
        public Category? Category { get; set; }

        [Required(ErrorMessage = "Please enter a movie title")]
        public string Title { get; set; }

        [Required(ErrorMessage = "Please enter a year")]
        [Range(1888,2099)]
        public int Year { get; set; }
        public string? Director { get; set; }
        public string? Rating { get; set; }

        [Required(ErrorMessage = "Please enter whether it was edited")]
        public bool Edited { get; set; }
        public string? LentTo { get; set; }
        public bool CopiedToPlex { get; set; }
        public string? Notes { get; set;}

    }
}
