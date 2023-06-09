﻿using System.ComponentModel.DataAnnotations;

namespace KidegaClone.Domain.Entities
{
    public class Author: IEntity
    {
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string Surname { get; set; }
        public string? Biography { get; set; }
        public string? Picture { get; set; } 
        public ICollection<Book>? Books { get; set; }
    }
}
