using System.ComponentModel.DataAnnotations;

namespace DBTreeView.Models
{
    public class Attribute
    {
        public int Id { get; set; }
        public int ObjectId { get; set; }
        [Required] public string? Name { get; set; }
        [Required] public string? Value { get; set; }

        public Object? Object { get; set; }
    }
}
