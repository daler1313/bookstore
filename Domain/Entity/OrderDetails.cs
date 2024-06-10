namespace Domain.Entity
{
    public class OrderDetails:BaseEntity
    {
        public int Quantity { get; set; }
        public float TotalPrice { get; set; }
        public int BookID { get; set; }
        public Book Books { get; set; }
        public int OrderId { get; set; }
        public Order Orders { get; set; }
    }
}
