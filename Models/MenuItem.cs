using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GrowEasy_API.Models
{
    public class MenuItem
    {
		[Required]
		public int Id { get; set; }        
        public string Name { get; set; }
        public string Description { get; set; }
        public string SpecialTag { get; set; }
        
        public int CategoryId { get; set; }
        public Category Category { get; set; }  

        [Range(1,10)]
        public double Nota { get; set; }
        [Required]
        public string Image { get; set; }
        public bool IsFavorite { get; set; }
    }
}
