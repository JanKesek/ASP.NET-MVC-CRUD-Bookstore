﻿using System;
using System.Collections.Generic;

namespace BookstoreCRUD.Models
{
    public partial class AuthorGenre
    {
        public int GenreId { get; set; }
        public int AuthorId { get; set; }

        public virtual Author Author { get; set; }
        public virtual Genre Genre { get; set; }
    }
}
