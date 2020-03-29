using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace ProjetAspCore.Pages
{
    public class Event : PageModel
    {

        
      private readonly ProjetAspCore.Data.ApplicationDbContext _context;
       public Event(ProjetAspCore.Data.ApplicationDbContext context)
        {
            _context = context;
        }
       
        public IActionResult OnGet()
        {
            var seances = _context.Seance.Select(e => new 
            {
                libele_seance = e.libele_seance,
                date_debut = e.date_debut.ToString("dd//MM/yyyy"),
                date_fin = e.date_fin.ToString("dd//MM/yyyy"),
                matiere = e.Matierecode_matiere,
                salle = e.Sallecode_salle


            }).ToList();
            return new JsonResult(seances);
       
        }
    }
}
