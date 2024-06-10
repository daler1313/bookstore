namespace Domain.Entity
{
    public class User:BaseEntity
    {
        public string Name { get; set; } 
        public string Email { get; set; }
        public int PhoneNumber { get; set; }
        public virtual ICollection<Order> Orders { get; set; } 
    }
}
