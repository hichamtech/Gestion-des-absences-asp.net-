namespace ProjetAspCore.Models
{
using System;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;
    public class Abscence
    {
       

         [Key]
         public int code_abs { get; set; }

        [DataType(DataType.Date)]
         [Display(Name = "Date de l'abscence")]
        public DateTime date_abs { get; set; }
       
       	
         public int etudiantcode_etudiant {get;set;}
         public Etudiant etudiant{get;set;}

        public int seancecode_seance {get;set;}

        public Seance seance {get;set;}


        public int professeurcode_professeur {get;set;}

        public Professeur professeur {get;set;}

    }
}