
namespace ProjetAspCore.Models
{
    using System;
    using System.ComponentModel.DataAnnotations;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations.Schema;

    public class Matiere
    {
        public Matiere()
        {
            this.Seances = new HashSet<Seance>();
        }
        [Key]
        public int code_matiere { get; set; }
        [Display(Name = " Libele Matière")]
        public string libele_matiere { get; set; }

        [Display(Name = "Nombre d'heures")]
        public int nbr_heures { get; set; }
        public int Filierecode_filiere { get; set; }
        [ForeignKey("Filierecode_filiere")]

        public virtual Filiere Filiere { get; set; }
        public int Professeurcode_professeur { get; set; }
        [ForeignKey("Professeurcode_professeur")]
        public virtual Professeur Professeur { get; set; }

        public virtual ICollection<Seance> Seances { get; set; }


        public double getTaux(int nbrheures, int nbrabs)
        {

            nbrheures = this.nbr_heures;

            double taux = (nbrabs / nbrheures) * 100;

            return taux;

        }

    }
}