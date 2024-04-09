using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using WebApplication2.Data.Enum;
namespace WebApplication2.Models.Club
{
    public class Club
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [MaxLength(100, ErrorMessage ="Title must not exceed 100 characters")]
        public string? Title { get; set; }
        public string? Description { get; set; }
        public string? Image { get; set; }
        [ForeignKey("Address")]
        public int AddressId { get; set; }
        public Address? Address { get; set; }
        [Required]
        public ClubCategory ClubCategory { get; set; }

        [ForeignKey("User")]
        public int? UserId { get; set; }
        public WebApplication2.Models.User.User? User { get; set; }


    }
}
