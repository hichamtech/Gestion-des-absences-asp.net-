namespace ProjetAspCore.Models
{
    using System;
    using System.ComponentModel.DataAnnotations;
    using System.Collections.Generic;
    using Microsoft.AspNetCore.Identity;

    public class Professeur
    {
        public Professeur()
        {
            this.Matieres = new HashSet<Matiere>();
        }

        [Key]
        public int code_professeur { get; set; }

        [PersonalData]
        [Display(Name = "Nom")]
        public string nom { get; set; }

        [Display(Name = "Prenom")]
        [PersonalData]
        public string prenom { get; set; }

        [Display(Name = "Email")]
        [PersonalData]
        public string email { get; set; }

        [Display(Name = "Numero tele")]
        public string telephone { get; set; }

        [Display(Name = "Nom complet Professeur")]
        public string FullName
        {
            get
            {
                return nom + "-" + prenom;
            }
        }

        public virtual ApplicationUser User { get; set; }


        public virtual ICollection<Matiere> Matieres { get; set; }
    }

}