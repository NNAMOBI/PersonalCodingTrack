using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;


namespace WebApplication2.Models.User
{
    public class User: IdentityUser
    {
        [Key]
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? Email { get; set; }
        public string? Password { get; set; }
        public int? AddressId { get; set; }
        public Address Address { get; set; }
        public ICollection<WebApplication2.Models.Club.Club>? Clubs { get; set; }
        public ICollection<WebApplication2.Models.Race.Race>? Races { get; set; }


    }
}
