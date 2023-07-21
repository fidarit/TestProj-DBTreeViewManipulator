namespace DBTreeView.Models
{
    internal class Link
    {
        public int Id { get; set; }
        public int IdParent { get; set; }
        public int IdChild { get; set; }
        public string LinkName { get; set; }
    }
}
