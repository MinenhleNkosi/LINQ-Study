namespace LINQ101
{
    public class Order
    {
        public int OrderId { get; set; }
        public List<OrderItems> Items { get; set; }
    }
}