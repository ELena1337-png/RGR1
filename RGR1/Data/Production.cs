namespace RGR1.Data
{
    public class Production
    {
        public int ProductionId { get; set; }
        public string? NamePr { get; set; }
        public string? Description {  get; set; }
        public float? Price { get; set; }
        public int CategoryId { get; set; }

        public virtual ICollection <Order>? Orders { get; set; }
        public virtual Category? Category { get; set; }

    }
}
