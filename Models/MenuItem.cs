using System.ComponentModel.DataAnnotations;

namespace GrowEasy_API.Models
{
    public class MenuItem
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        public string Description { get; set; }
        public string SpecialTag { get; set; }
        
        public int CategoryId { get; set; }
        [Range(1,int.MaxValue)]
        public double Nota { get; set; }
        [Required]
        public string Image { get; set; }
        public bool IsFavorite { get; set; }
    }
}
