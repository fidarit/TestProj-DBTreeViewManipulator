namespace DBTreeView.Models.Serialized
{
    [Serializable]
    public class SerializedLink
    {
        public int IdParent { get; set; }
        public int IdChild { get; set; }
        public string? LinkName { get; set; } = null!;

        public SerializedLink() { }

        public SerializedLink(Link source)
        {
            IdParent = source.IdParent;
            IdChild = source.IdChild;
            LinkName = source.LinkName;
        }
    }
}
