using eTickets.Data.Base;
using System.ComponentModel.DataAnnotations;

namespace eTickets.Models
{
    public class Cinema : IEntityBase
    {
        [Key]
        public int Id { get; set; }

        [Display(Name = "Cinema Logo")]
        [Required(ErrorMessage = "Logo Phim is required")]
        public string Logo { get; set; }
        
        [Display(Name = "Tên Phim")]
        [Required(ErrorMessage = "Logo Phim is required")]
        public string Name { get; set; }
        
        [Display(Name = "Mô tả")]
        [Required(ErrorMessage = "Mô tả is required")]
        public string Description { get; set; }
        
        // Relationships
        public List<Movie>? Movies { get; set; }
    }
}
