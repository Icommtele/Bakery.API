namespace Bakery.API.DTOs
{
    public class OrderRequest
    {
        public int CakeId { get; set; }
        public int Quantity { get; set; }
        public DateTime ReadyTime { get; set; }
    }
}
