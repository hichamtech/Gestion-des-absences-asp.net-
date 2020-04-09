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
    public class DetailsModel : PageModel
    {
        private readonly ProjetAspCore.Data.ApplicationDbContext _context;

        public DetailsModel(ProjetAspCore.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        public Seance Seance { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Seance = await _context.Seance.Include(e => e.Matiere)
                                           .Include(e => e.Abscences)
                                           .Include(e => e.Salle)
                                           .Include(e => e.Matiere.Filiere)
                                           .Include(e => e.Matiere.Professeur)
            .FirstOrDefaultAsync(m => m.code_seance == id);

            ViewData["Presence"] = _context.Abscence
                           .Where(a => a.seance.code_seance == id && a.seance.Matierecode_matiere ==
                               Seance.Matierecode_matiere && a.seance.Salle.code_salle == Seance.Sallecode_salle
                                && Seance.date_debut.Date == a.seance.Abscences.FirstOrDefault().date_abs.Date
                               )
                           .Include(e => e.etudiant)
                           .Include(F => F.etudiant.Filiere)
                           .Include(P => P.professeur)
                           .ToList();

            ViewData["Absence"] = _context.Etudiant
                     .Where(c => !_context.Abscence
                    .Select(b => b.etudiantcode_etudiant)
                     .Contains(c.code_etudiant)
                     && c.Filiere.Matieres.FirstOrDefault().Seances.FirstOrDefault().code_seance == id

                     )
                     .Include(e => e.Filiere)
                     .Include(e => e.Abscences)
                     .Include(e => e.Filiere.Matieres)
                     .ToList();

            if (Seance == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
