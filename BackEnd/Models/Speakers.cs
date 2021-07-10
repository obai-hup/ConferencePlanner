using System.ComponentModel.DataAnnotations;

namespace BackEnd.Models
{
    public class Speakers
    {
        public int ID { get; set; }

        [Required]
        [StringLength(200)]
        public string Name { get; set; }

        [StringLength(4000)]
        public string Bio { get; set; }

        [StringLength(2000)]
        public virtual string WebSite { get; set; }
        
        
        
        
        
        
        
    }
}