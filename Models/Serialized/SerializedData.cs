namespace DBTreeView.Models.Serialized
{
    [Serializable]
    public class SerializedData
    {
        public SerializedLink[] Links { get; set; } = null!;
        public SerializedObject[] Objects { get; set; } = null!;
        public SerializedAttribute[] Attributes { get; set; } = null!;

        public SerializedData() { }

        public SerializedData(ApplicationContext dbContext)
        {
            Links = dbContext.Links
                .Select(x => new SerializedLink(x))
                .ToArray();

            Objects = dbContext.Objects
                .Select(x => new SerializedObject(x))
                .ToArray();

            Attributes = dbContext.Attributes
                .Select(x => new SerializedAttribute(x))
                .ToArray();
        }
    }
}
