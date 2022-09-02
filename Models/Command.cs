using System.ComponentModel.DataAnnotations;

namespace CLI_REST_API.Models
{
    public class Command
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string? Description { get; set; }
        [Required]
        public string? Platform { get; set; }
        [Required]
        public string? CommandLine { get; set; }
    }
}