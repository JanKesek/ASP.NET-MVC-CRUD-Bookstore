using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BookstoreCRUD.Models
{
    public partial class Book
    {
        public Book()
        {
            BookGenre = new HashSet<BookGenre>();
            OrderDetails = new HashSet<OrderDetails>();
        }

        [Key]
        [Column("ISBN")]
        public int Isbn { get; set; }
        [Required]
        [StringLength(60)]
        public string Title { get; set; }
        public byte? Stock { get; set; }
        [Column(TypeName = "money")]
        public decimal? Price { get; set; }
        [StringLength(35)]
        public string Picture { get; set; }
        public int? PageCount { get; set; }
        [StringLength(15)]
        public string Language { get; set; }

        [InverseProperty("IsbnNavigation")]
        public virtual ICollection<BookGenre> BookGenre { get; set; }
        [InverseProperty("IsbnNavigation")]
        public virtual ICollection<OrderDetails> OrderDetails { get; set; }
    }
}
