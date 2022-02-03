using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Hilton_Movie_Collection.Models
{
    public class AddedMovie
    {
        [Key]
        [Required]
        public int MovieId { get; set; }

        [Required(ErrorMessage = "Hey there, you need to enter a title!")]
        public string Title { get; set; }

        [Required(ErrorMessage = "Hey there, you need to enter a year!")]
        public int Year { get; set; }

        [Required(ErrorMessage = "Hey there, you need to enter a director!")]
        public string Director { get; set; }

        [Required(ErrorMessage = "Hey there, you need to enter a rating!")]
        public string Rating { get; set; }

        public bool Edited { get; set; }

        public string LentTo { get; set; }

        [MaxLength(25)]
        public string Notes { get; set; }

        //foreign key relationship
        public int CategoryId { get; set; }
        
        public Category Category { get; set; }
    }
}
