namespace WebCatalog.Models
{
    public class Unit
    {
        public Unit(int Id)
        {
            this.Id = Id;
        }
        public Unit() { }

        public int Id { get; protected set; }
        public string? Name { get; set; }
        public string? Description { get; set; }
        public double Price { get; set; }
        public int Quantity { get; set; }
        public DateTime AddedDate { get; set; } = DateTime.Now;
        public List<QuantityHistoryLog> QuantityHistory { get; set; } = new List<QuantityHistoryLog>();
        public List<Category> Categories { get; set; } = new List<Category>();

        
            
    }
}
