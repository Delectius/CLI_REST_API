using System.ComponentModel.DataAnnotations;

namespace CLI_REST_API.Dtos
{
    public class CommandReadDtos
    {
        public int Id { get; set; }
        public string? Description { get; set; }
        public string? Platform { get; set; }
        public string? CommandLine { get; set; }
    }
}