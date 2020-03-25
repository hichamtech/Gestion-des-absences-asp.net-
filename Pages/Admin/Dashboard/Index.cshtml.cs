using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace ProjetAspCore.Pages
{
    public class dashboardModel : PageModel
    {

        
      private readonly ProjetAspCore.Data.ApplicationDbContext _context;
       public dashboardModel(ProjetAspCore.Data.ApplicationDbContext context)
        {
            _context = context;
        }
        public int Nbretudiants;
        public int Nbrprofesseurs;
        public int Nbrsalles;
        
        public int NbrFilieres;
        public void OnGet()
        {
             Nbretudiants = _context.Etudiant.Count();
           Nbrprofesseurs = _context.Professeur.Count(); 
           Nbrsalles = _context.Salle.Count();
           NbrFilieres = _context.Filiere.Count();
        }
    }
}
