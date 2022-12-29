namespace WebApplication2.Models
{
    public class Size
    {
        public int Id { get; set; }
      public ICollection<Product> Products { get; set;}
    }
}
