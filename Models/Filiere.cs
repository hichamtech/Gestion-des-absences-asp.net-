using System;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;
namespace ProjetAspCore.Models
{
    public class Filiere
    {
       public Filiere()
        {
            this.Etudiants = new HashSet<Etudiant>();
            this.Matieres = new HashSet<Matiere>();
        }
        [Key]
        public int code_filiere { get; set; }

        [Display(Name = "Filière")]
        public string libele_filiere { get; set; }
    
        public virtual ICollection<Etudiant> Etudiants { get; set; }
        public virtual ICollection<Matiere> Matieres { get; set; }
    }

        
    
}