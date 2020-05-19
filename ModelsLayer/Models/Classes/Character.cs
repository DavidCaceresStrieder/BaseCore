using ModelsLayer.EntityFramework;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace ModelsLayer.Models
{
    [Table("Characters")]
    public class Character : BaseEntity
    {
        public string name { get; set; }        

        public CharacterClass CharacterClass { get; set; }        

    }
}
