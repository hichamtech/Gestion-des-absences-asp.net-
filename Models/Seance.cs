namespace ProjetAspCore.Models
{
using System;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;
    public class Seance
    {
        [Key]
         public int code_seance { get; set; }
        
        [Display(Name = "Libele Seance")]
        public string libele_seance { get; set; }
        
        [DataType(DataType.DateTime)]
        [Display(Name = "Date Debut")]
        public DateTime date_debut { get; set; }
                
        [DataType(DataType.DateTime)]
        [Display(Name = "Date Fin")]
        public DateTime date_fin { get; set; }

        public int Matierecode_matiere {get;set;}

        public virtual Matiere Matiere { get; set; }

        public int Sallecode_salle {get;set;}
        public virtual Salle Salle { get; set; }
    }
        
    
}