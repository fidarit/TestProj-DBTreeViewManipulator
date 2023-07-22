namespace DBTreeView.Models.Serialized
{
    [Serializable]
    public class SerializedObject
    {
        public int Id { get; set; }
        public string? Type { get; set; } = null!;
        public string? Product { get; set; } = null!;

        public SerializedObject() { }

        public SerializedObject(Object source)
        {
            Id = source.Id;
            Type = source.Type;
            Product = source.Product;
        }
    }
}
