namespace Domain.Entity
{
    public class Author:BaseEntity
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public int PhoneNumber { get; set; }
        public int Experience { get; set; }
        public virtual ICollection<Book> Books { get; set; }
    }
}
