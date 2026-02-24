namespace Bakery.API.Models
{
    public class Cake
    {

        public int CakeId { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public string ImageUrl { get; set; }
        public int CategoryId { get; set; }
        public bool IsAvailable { get; set; }
    }
}
