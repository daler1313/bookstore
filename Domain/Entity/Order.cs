using Domain.Enum;

namespace Domain.Entity
{
    public class Order : BaseEntity
    {
        public Status Status { get; set; }
        public int UserId {  get; set; }
        public User Users { get; set; }
        public virtual ICollection<OrderDetails> OrderDetails {  get; set; }
    }
}
