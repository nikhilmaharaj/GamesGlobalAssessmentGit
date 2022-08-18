using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using GamesGlobalAssessment.Models;

namespace GamesGlobalAssessment.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<GamesGlobalAssessment.Models.TVShow> TVShow { get; set; }
        public DbSet<GamesGlobalAssessment.Models.Episode> Episode { get; set; }
        public DbSet<GamesGlobalAssessment.Models.Users> Users { get; set; }
        public DbSet<GamesGlobalAssessment.Models.ViewTVShows> ViewTVShows { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<ViewTVShows>().ToView(nameof(ViewTVShows)).HasKey(t => t.TVShowID);
        }
    }
}
