using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopMVC.Models
{
    public class Cinema
    {
        public int Id { get; set; }
        public string? Logo { get; set; }
        public string? Name { get; set; }
        public string? Description { get; set; }

        //Relationships

        public List<Movie>? Movies { get; set; }

    }
}
