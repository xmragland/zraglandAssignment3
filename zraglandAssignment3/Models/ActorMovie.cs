using System.ComponentModel.DataAnnotations.Schema;

namespace zraglandAssignment3.Models
{
    public class ActorMovie
    {
        public int AMId { get; set; }
        [ForeignKey("Actor")]
        public int ActorId { get; set; }
        public Actor? Actor { get; set; }

        [ForeignKey("Movie")]
        public int Id { get; set; }   
        public Movie? Movie { get; set; }

    }
}
