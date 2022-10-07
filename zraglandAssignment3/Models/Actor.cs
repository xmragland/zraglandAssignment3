using System.ComponentModel.DataAnnotations;

namespace zraglandAssignment3.Models
{
    public class Actor
    {
        public int ActorId { get; set; }
        public string ActorName { get; set; }
        public string Gender { get; set; }  
        public int Age { get; set; }
        [Url]
        public string Link { get; set; }    
        public byte[]? Photo { get; set; }  
    }
}
