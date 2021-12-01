using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;


namespace Solucja_Lab4.Models
{
    public class Books
    {
        public int Id { get; set; }
        public string Title { get; set; }
        [DataType(DataType.Date)] 
        public DateTime ReleaseDate { get; set; }
        public string Author { get; set; }
        public int Rating { get; set; }

    }
}
