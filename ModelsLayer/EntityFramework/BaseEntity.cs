using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace ModelsLayer.EntityFramework
{
    public abstract class BaseEntity
    {
        [Key]
        public Guid ID { get; set; }
    }
}
