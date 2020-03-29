
namespace ProjetAspCore.Models
{
    using System;
    using System.ComponentModel.DataAnnotations;
    using System.Collections.Generic;
    public class Etudiant
    {

        public Etudiant(){
            this.Abscences = new HashSet<Abscence>();
        }
         [Key]
        public int code_etudiant { get; set; }
         [Display(Name = "Nom")]
        public string nom { get; set; }
         [Display(Name = "Prenom")]
        public string prenom { get; set; }
        [Display(Name = "Cin")]
        public string cin { get; set; }

        

        
        [DataType(DataType.Date)]
        [Display(Name = "Date de Naissance")]
        public DateTime date_naissance { get; set; }
         [Display(Name = "Email")]
         [EmailAddress]
        public string email { get; set; }  

        [Display(Name = "Code RFID")]

         public string code_rfid
        {
          get;set;
        }
        public int Filierecode_filiere {get;set;}
        public  Filiere Filiere { get; set; }
        

      public virtual ICollection<Abscence> Abscences { get; set; }
    }
}