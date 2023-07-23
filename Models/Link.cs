using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DBTreeView.Models
{
    public class Link
    {
        public int Id { get; set; }
        public int IdParent { get; set; }
        public int IdChild { get; set; }
        [Required] public string? LinkName { get; set; }

        [ForeignKey(nameof(IdParent))]
        public Object Parent { get; set; } = null!;

        [ForeignKey(nameof(IdChild))]
        public Object Child { get; set; } = null!;
    }
}
