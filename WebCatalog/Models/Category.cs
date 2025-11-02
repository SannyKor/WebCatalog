namespace WebCatalog.Models
{
    public class Category
    {
        public Category() { }
        public Category(string name, int? parentId = null)
        {
            ParentId = parentId;
            Name = name;
        }
        public int Id { get; set; }
        public string? Name { get; set; }
        public int? ParentId { get; set; }
        public List<Category> SubCategories { get; set; } = new List<Category>();
        public List<Unit> Units { get; set; } = new List<Unit>();

    }
}
