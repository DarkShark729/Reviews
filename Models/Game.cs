namespace MovieReviews1.Models
{
    public class Game
    {
        public int GameId { get; set; }
        public string GameName { get; set; }
        public string GameDescription { get; set; }
        public int Rating { get; set; }

        public ICollection<Review> Reviews { get; set; }





    }
}
