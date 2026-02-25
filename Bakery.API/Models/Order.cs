namespace Bakery.API.Models
{
    public class Order
    {

        public int OrderId { get; set; }
        public string OrderNumber { get; set; }
        public int CakeId { get; set; }
        public int Quantity { get; set; }
        public decimal TotalAmount { get; set; }
        public DateTime ReadyTime { get; set; }
        public DateTime OrderDate { get; set; }
        public string Status { get; set; }
    }
}
