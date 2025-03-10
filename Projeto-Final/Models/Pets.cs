﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Projeto_Final.Models
{
    public class Pets
    {
        [Key]
        public int Id{ get; set; }
        public DateTime Publication_date { get; set; }
        public string Name { get; set; }
        public string Animal { get; set; }
        public string Breed { get; set; }
        public string Age { get; set; }
        public string Size { get; set; } 
        public bool Adopted { get; set; }
        public virtual int Current_owner_id { get; set; }
        public List<Photo> Photos { get; set; }
        public string Description { get; set; }
    }
}
