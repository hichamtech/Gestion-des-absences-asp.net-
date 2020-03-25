namespace ProjetAspCore.Models
{
using System;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;
    public class Salle
    {
        public Salle()
        {
            this.Seances = new HashSet<Seance>();
        }
        [Key]
        public int code_salle { get; set; }

        [Display(Name = "Numero de Salle")]
        public string numero_salle { get; set; }
    
        public virtual ICollection<Seance> Seances { get; set; }
        
    }
}