﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Vidly.Dtos
{
    public class MovieDto
    {
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        public int GenreId { get; set; }
        public GenreDto Genre { get; set; }
        public DateTime ReleasedDate { get; set; }
        public DateTime DateAdded { get; set; } = DateTime.Now;
        [Range(1, 20)]
        public int Stock { get; set; }
    }
}