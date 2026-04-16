namespace RGR1.Data
{
    public class Order
    {
        public int OrderId { get; set; }
        public int ProductionId {  get; set; }
        public int? Count { get; set; }
        public DateOnly? DateOrder { get; set; }
        public float? TotalCost { get; set; }

        public virtual Production? Production { get; set; }

    }
}
