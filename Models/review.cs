namespace MovieReviews1.Models
{
    public class Review
    {
       
        public int Id { get; set; }
        public int GameId { get; set; }
        public Game Game { get; set; }
        public string Title { get; set; }
        public string ReviewDescription { get; set; }
        public int Rating { get; set; }
        
    }
}
