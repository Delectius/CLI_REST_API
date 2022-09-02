using System.ComponentModel.DataAnnotations;

namespace CLI_REST_API.Dtos
{
    public class CommandCreateDto
    {
        [Required]
        public string? Description { get; set; }
        [Required]
        public string? Platform { get; set; }
        [Required]
        public string? CommandLine { get; set; }
    }
}