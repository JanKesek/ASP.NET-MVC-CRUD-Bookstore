using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BookstoreCRUD.Models
{
    public partial class Author
    {
        public Author()
        {
            AuthorGenre = new HashSet<AuthorGenre>();
        }

        [Key]
        [Column("AuthorID")]
        public int AuthorId { get; set; }
        [StringLength(20)]
        public string FirstName { get; set; }
        [StringLength(20)]
        public string LastName { get; set; }

        [InverseProperty("Author")]
        public virtual ICollection<AuthorGenre> AuthorGenre { get; set; }
    }
}
