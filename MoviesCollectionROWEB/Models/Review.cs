using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MoviesCollectionROWEB.Models
{
    public class Review
    {
        public Review()
        {
            ReviewDate = DateTime.Now;
        }
        public int Id { get; set; }
        public DateTime ReviewDate { get; set; }
        public string Name { get; set; }
        public string Content { get; set; }
        public int MovieId { get; set; }
    }
}
