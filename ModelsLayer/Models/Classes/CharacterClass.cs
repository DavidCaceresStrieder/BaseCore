using ModelsLayer.EntityFramework;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace ModelsLayer.Models
{
    [Table("CharacterClasess")]
    public class CharacterClass : BaseEntity
    {
        
        public string name { get; set; }
    }
}
