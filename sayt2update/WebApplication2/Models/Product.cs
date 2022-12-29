namespace WebApplication2.Models
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Price { get; set; }
        public string Image { get; set; }
        public string Descriptions { get; set; }
        public int Count { get; set; }

        public int SizeId;
        public int CategoryId;
        public int ColorId;


    }
}
