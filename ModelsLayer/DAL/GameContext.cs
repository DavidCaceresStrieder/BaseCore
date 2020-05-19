using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using ModelsLayer.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace ModelsLayer.DAL
{
    public class GameContext : DbContext
    {        
        public GameContext(DbContextOptions<GameContext> options) : base(options) { }
        //@"Server=DESKTOP-3MM6G0I\SQLEXPRESS;Database=RollGames;Trusted_Connection=True;ConnectRetryCount=0"
        public DbSet<User> Users { get; set; }
        public DbSet<Game> Games { get; set; }
        public DbSet<Character> Characters { get; set; }
        public DbSet<CharacterClass> CharacterClasses { get; set; }

    }
}
