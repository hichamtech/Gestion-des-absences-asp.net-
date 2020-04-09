using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using ProjetAspCore.Models;
namespace ProjetAspCore.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
    public DbSet<ProjetAspCore.Models.Etudiant> Etudiant { get; set; }
    public DbSet<ProjetAspCore.Models.Filiere> Filiere { get; set; }

    public DbSet<ProjetAspCore.Models.Matiere> Matiere { get; set; }

    public DbSet<ProjetAspCore.Models.Professeur> Professeur { get; set; }

    public DbSet<ProjetAspCore.Models.Salle> Salle { get; set; }

    public DbSet<ProjetAspCore.Models.Seance> Seance { get; set; }

    public  DbSet<ProjetAspCore.Models.Abscence> Abscence { get; set; }



     protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
           builder.Entity<Etudiant>().ToTable("Etudiant");
            builder.Entity<Filiere>().ToTable("Filiere");
            builder.Entity<Matiere>().ToTable("Matiere");
            builder.Entity<Professeur>().ToTable("Professeur");
            builder.Entity<Salle>().ToTable("Salle");
            builder.Entity<Seance>().ToTable("Seance");
            builder.Entity<Abscence>().ToTable("Abscence");
        }

    }
    
}
