using System.ComponentModel.DataAnnotations;

namespace DBTreeView.Models
{
    public class Object
    {
        public int Id { get; set; }
        [Required] public string? Type { get; set; }
        [Required] public string? Product { get; set; }

        public List<Attribute> Attributes { get; set; } = new();
    }
}
