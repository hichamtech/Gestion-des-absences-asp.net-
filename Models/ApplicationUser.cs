using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Security.Claims;
using System.Threading.Tasks;

namespace ProjetAspCore.Models
{
    public class ApplicationUser : IdentityUser
    {


        public int code_professeur { get; set; }
        [ForeignKey("code_professeur")]
        public virtual Professeur Professeur { get; set; }



    }


}