namespace WebCatalog.Models
{
    public class QuantityHistory
    {
        public QuantityHistory(int unitId, int newUnitQuantity, DateTime dateOfChange, Guid userId)
        {

            UnitId = unitId;
            NewUnitQuantity = newUnitQuantity;
            DateOfChange = dateOfChange;
            UserId = userId;
        }
        public QuantityHistory() { }
        public Guid UserId { get; set; }
        public int Id { get; set; }
        public int UnitId { get; protected set; }
        public int NewUnitQuantity { get; protected set; }
        public DateTime DateOfChange { get; protected set; }
    }
}
