using System.ComponentModel.DataAnnotations;

namespace JwtAuthDemo.Models
{
    public class User
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [MaxLength(50)]
        public string Username { get; set; }

        [Required]
        public string Password { get; set; }

        [MaxLength(50)]
        public string Role { get; set; }

    }
}
