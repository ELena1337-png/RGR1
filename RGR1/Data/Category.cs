namespace RGR1.Data
{
    public class Category
    {
        public int CategoryId { get; set; }
        public string? NameCategory { get; set; }
        public virtual ICollection<Production>? Productions { get; set; }

    }
}
