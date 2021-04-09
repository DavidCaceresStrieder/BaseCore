using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using ModelsLayer.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace ModelsLayer.DAL
{
    public class WorkContext : DbContext
    {        
        public WorkContext(DbContextOptions<WorkContext> options) : base(options) { }        
        public DbSet<User> Users { get; set; }


    }
}
