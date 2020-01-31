using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BookstoreCRUD.Models
{
    public partial class BookAuthor
    {
        [Column("ISBN")]
        public int? Isbn { get; set; }
        [Column("AuthorID")]
        public int? AuthorId { get; set; }
    }
}
