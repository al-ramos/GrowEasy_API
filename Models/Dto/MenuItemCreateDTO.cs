using Microsoft.AspNetCore.Http;
using System.ComponentModel.DataAnnotations;

namespace GrowEasy_API.Models.Dto
{
    public class MenuItemCreateDTO
    {
        [Required]
        public string Name { get; set; }
        public string Description { get; set; }
        public string SpecialTag { get; set; }
        public int CategoryId { get; set; }
        [Range(1, int.MaxValue)]
        public double Nota { get; set; }
        public IFormFile File { get; set; }
		public bool IsFavorite { get; set; }
		}
}
