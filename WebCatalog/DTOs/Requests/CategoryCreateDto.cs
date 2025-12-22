namespace WebCatalog.DTOs.Requests
{
    public class CategoryCreateDto
    {
        public string CategoryName { get; set; }
        public int? ParentId { get; set; } 
    }
}
