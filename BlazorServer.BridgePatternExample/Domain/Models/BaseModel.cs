using System.ComponentModel.DataAnnotations;

namespace BlazorServer.BridgePatternExample.Domain.Models
{
    public class BaseModel
    {
        [Required]
        public int Id { get; set; }

        [Required]
        public string? Name { get; set; }

        public string? Description { get; set; }
    }
}
