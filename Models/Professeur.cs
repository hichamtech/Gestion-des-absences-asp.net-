namespace ProjetAspCore.Models
{
using System;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;
    public class Professeur
    {
        public Professeur()
        {
            this.Matieres = new HashSet<Matiere>();
        }
    
         [Key]
        public int code_professeur { get; set; }
        [Display(Name = "Nom")]
        public string nom { get; set; }
           [Display(Name = "Prenom")]
        public string prenom { get; set; }
        [Display(Name = "Email")]
        public string email { get; set; }

        [Display(Name = "Nom complet Professeur")]
        public string FullName
        {
            get
            {
                return nom + "-" + prenom;
            }
        }
    
        public virtual ICollection<Matiere> Matieres { get; set; }
    }
    
}