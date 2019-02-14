using System;

namespace my_first_web_app.Models
{
    public class Movie
    {
        public int Id { get; set; }
        public string Name { get; set; }
        //public MovieGenre MovieGenre { get; set; }
        //public byte MovieGenreId { get; set; }
        public DateTime? ReleaseDate { get; set; }
        public DateTime? DateAdded { get; set; }
        public int StockNumber { get; set; }

    }
}