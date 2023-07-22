namespace DBTreeView.Models
{
    public class Object
    {
        public int Id { get; set; }
        public string? Type { get; set; }
        public string? Product { get; set; }

        public List<Attribute> Attributes { get; set; } = new();
    }
}
