namespace Domain.Entity
{
    public class Book:BaseEntity
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public int AuthorId { get; set; }
        public Author Authors { get; set; }
        public int GenreId { get; set; }
        public Genre Genres { get; set; }
        public virtual ICollection<OrderDetails> OrderDetails { get; set; }
    }
}
