using ModelsLayer.EntityFramework;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace ModelsLayer.Models
{
    [Table("Games")]
    public class Game : BaseEntity
    {
        public string Name { get; set; }
        public User GM { get; set; }

        public IList<Character> characters { get; set; }
        
    }
}
