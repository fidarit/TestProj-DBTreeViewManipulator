namespace DBTreeView.Models.Serialized
{
    [Serializable]
    public class SerializedAttribute
    {
        public int Id { get; set; }
        public string? Name { get; set; } = null!;
        public string? Value { get; set; } = null!;

        public SerializedAttribute() { }

        public SerializedAttribute(Attribute source)
        {
            Id = source.ObjectId;
            Name = source.Name;
            Value = source.Value;
        }
    }
}
