using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;


namespace ShopMVC.Models
{
    public class Producer
    {
        public int Id { get; set; }
        [Display(Name = "Profile Picture URL")]
        public string? ProfilePictureURL { get; set; }
        [Display(Name = "Full Name")]
        public string? FullName { get; set; }
        [Display(Name = "Biography")]
        public string? Bio { get; set; }

        // Relationships

        public List<Movie>? Movies { get; set; }

    }
}
