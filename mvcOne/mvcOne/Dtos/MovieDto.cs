﻿using mvcOne.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace mvcOne.Dtos
{
    public class MovieDto
    {
        public int Id { get; set; }

        [Required]
        [StringLength(255)]
        public string Name { get; set; }
        public bool IsSubscribedToNewsLatter { get; set; }
        public DateTime ReleaseDate { get; set; }
        public string Description { get; set; }

      
        public MovieType MovieType { get; set; }
        public byte MovieTypeId { get; set; }
    }
}