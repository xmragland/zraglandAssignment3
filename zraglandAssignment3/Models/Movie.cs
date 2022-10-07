using System.ComponentModel.DataAnnotations;

namespace zraglandAssignment3.Models
{
    public class Movie
    {
        public int Id { get; set; }
        public string Title { get; set; }
        [Url]
        public string Link { get; set; }
        public string Genre { get; set; }
        public string YearOfRelease { get; set; }

        public byte[]? Poster { get; set; }
    }
}
