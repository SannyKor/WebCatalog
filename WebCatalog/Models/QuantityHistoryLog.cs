namespace WebCatalog.Models
{
    public class QuantityHistoryLog
    {
        public QuantityHistoryLog(int unitId, int newUnitQuantity, DateTime dateOfChange, Guid userId)
        {

            UnitId = unitId;
            NewUnitQuantity = newUnitQuantity;
            DateOfChange = dateOfChange;
            UserId = userId;
        }
        public QuantityHistoryLog() { }
        public Guid UserId { get; set; }
        public int Id { get; set; }
        public int UnitId { get; protected set; }
        public int NewUnitQuantity { get; protected set; }
        public DateTime DateOfChange { get; protected set; }
    }
}
