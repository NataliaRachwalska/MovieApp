using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace movie_app.Components
{
    public class Movie
    {
        public int Id { get; set; }
        public string? Title { get; set; }
        public string? Description { get; set; }

        [Column(TypeName = "Date")] 
        [DataType(DataType.Date)]
        public DateTime? RelaseDate { get; set; }
        public float? Rate { get; set; }
        public float? Sum { get; set; }

        public int Quantity { get; set; }
        public string? ImageUrl { get; set; }
       
    }
}
