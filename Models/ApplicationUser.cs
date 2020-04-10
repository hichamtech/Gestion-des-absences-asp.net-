using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Security.Claims;
using System.Threading.Tasks;

namespace ProjetAspCore.Models
{
    public class ApplicationUser : IdentityUser
    {



        [Display(Name = "Nom")]
        public string nom { get; set; }
        [Display(Name = "Prenom")]
        public string prenom { get; set; }
        public char status { get; set; }

        public virtual Professeur Professeur { get; set; }


    }


}