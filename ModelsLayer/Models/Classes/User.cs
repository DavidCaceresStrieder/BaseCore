using ModelsLayer.EntityFramework;
using ModelsLayer.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace ModelsLayer
{
    [Table("Users")]
    public class User : BaseEntity
    {
        public string UserName { get; set; }
        public string Password { get; set; }

        public List<Character> Characters { get; set; }
        
    }
}
