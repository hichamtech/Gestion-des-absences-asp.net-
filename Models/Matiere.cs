
namespace ProjetAspCore.Models
{
using System;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;
    public class Matiere
    {
        public Matiere()
        {
            this.Seances = new HashSet<Seance>();
        }
        [Key]
        public int code_matiere { get; set; }
         [Display(Name = "Matière")]
        public string libele_matiere { get; set; }

        [Display(Name = "Nombre d'heures")]
        public int nbr_heures{get;set;}
        public int Filierecode_filiere {get;set;}
        public virtual Filiere Filiere { get; set; }
        public int Professeurcode_professeur {get;set;}

        public virtual Professeur Professeur { get; set; }
        
        public virtual ICollection<Seance> Seances { get; set; }
    }
}