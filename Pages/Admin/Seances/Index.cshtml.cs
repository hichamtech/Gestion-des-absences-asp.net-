using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using ProjetAspCore.Data;

using ProjetAspCore.Models;

namespace ProjetAspCore.Pages.Seances__referenceScriptLibraries
{
    public class IndexModel : PageModel
    {
        private readonly ProjetAspCore.Data.ApplicationDbContext _context;

        public IndexModel(ProjetAspCore.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        public IList<Seance> Seance { get;set; }


        public async Task OnGetAsync()
        {
            Seance = await _context.Seance
            .Include(c => c.Matiere)
            .Include(s => s.Salle)
            .AsNoTracking()
            .ToListAsync();

        }
        
        public IActionResult OnGetEvents(){

            var seances = _context.Seance.Select(e => new 
            {
                libele_seance = e.libele_seance,
                date_debut = e.date_debut,
                date_fin = e.date_fin,
                matiere = e.Matiere.libele_matiere,
                salle = e.Salle.numero_salle,
                filliere = e.Matiere.Filiere.libele_filiere,
                description = " Salle: " + e.Salle.numero_salle + " | Matiere: " + e.Matiere.libele_matiere 
                                + " | Filliere: "  + e.Matiere.Filiere.libele_filiere

            }).ToList();
            return new JsonResult(seances);
        }

        
    }
}
