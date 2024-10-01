using eTickets.Data.Base;
using System.ComponentModel.DataAnnotations;

namespace eTickets.Models
{
    public class Actor : IEntityBase
    {
        [Key]
        public int Id { get; set; }

        [Display(Name = "Ảnh")]
        [Required(ErrorMessage = "Ảnh profile is required")]
        public string ProfilePictureURL { get; set; }
        
        [Display(Name = "Họ và Tên")]
        [Required(ErrorMessage = "Họ và Tên is required")]
        [StringLength(50, MinimumLength = 3, ErrorMessage = "Họ và Tên phải có độ dài từ 3 - 50 kí tự")]
        public string FullName { get; set; }
        
        [Display(Name = "Tiểu sử")]
        [Required(ErrorMessage = "Tiểu sử is required")]
        public string Bio { get; set; }

        // Relationships
        public List<Actor_Movie>? Actors_Movies { get; set; }
    }
}
