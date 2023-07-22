namespace DBTreeView.Models
{
    public class Attribute
    {
        public int Id { get; set; }
        public int ObjectId { get; set; }
        public string? Name { get; set; }
        public string? Value { get; set; }

        public Object? Object { get; set; }
    }
}
