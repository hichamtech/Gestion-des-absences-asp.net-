using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using ProjetAspCore.Data;

using ProjetAspCore.Models;

namespace ProjetAspCore.Pages.MAtieres__referenceScriptLibraries
{
    [Authorize(Roles = "Admin")]
    public class IndexModel : PageModel
    {
        private readonly ProjetAspCore.Data.ApplicationDbContext _context;

        public IndexModel(ProjetAspCore.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        public IList<Matiere> Matiere { get; set; }
        public float nbr_abs { get; set; }
        public async Task OnGetAsync()
        {

            var nbrheure = _context.Matiere.Select(e => e.nbr_heures);

            // var listematier = _context.Matiere.FirstOrDefault().code_matiere;
            // var listematier = _context.Matiere.FirstOrDefault().code_matiere;
            // var abs = _context.Abscence.Where(e => e.seance.Matierecode_matiere == )

            //@(( ((item.Seances.Select(a => a.Abscences).Count() * 2 ) * item.nbr_heures)   )) %

            Matiere = await _context.Matiere
            .Include(c => c.Filiere)
            .Include(p => p.Professeur)
            .Include(a => a.Seances)
            .ToListAsync();

            nbr_abs = _context.Etudiant
               .Where(c => !_context.Abscence
              .Select(b => b.etudiantcode_etudiant)
               .Contains(c.code_etudiant) && c.Filiere.Matieres.FirstOrDefault().code_matiere == Matiere.FirstOrDefault().code_matiere


               )

               .Count();
        }
    }
}
