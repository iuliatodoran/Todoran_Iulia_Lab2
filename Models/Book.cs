using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Security.Policy;

namespace Todoran_Iulia_Lab2.Models
{
    public class Book
    {
        public int ID { get; set; }

        [Display(Name = "Book Title")]
        public string Title { get; set; }
<<<<<<< HEAD
=======
        public string Author { get; set; }
>>>>>>> 4c50c10bd6f2a7a756e89f8e06de59bfddd73a35

        [Column(TypeName = "decimal(6, 2)")]
        public decimal Price { get; set; }

        [DataType(DataType.Date)]
        public DateTime PublishingDate { get; set; }
<<<<<<< HEAD
        public int? AuthorID { get; set; }
        public Author? Author { get; set; }
        public int? PublisherID { get; set; }
        public Publisher? Publisher { get; set; } //navigation property
        public ICollection<BookCategory> BookCategory { get; set; }
=======
        public int? PublisherID { get; set; }
        public Publisher? Publisher { get; set; } //navigation property
>>>>>>> 4c50c10bd6f2a7a756e89f8e06de59bfddd73a35
    }
}
