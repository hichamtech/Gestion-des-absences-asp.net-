using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using ProjetAspCore.Data;

using ProjetAspCore.Models;

namespace ProjetAspCore.Pages.espace_professeur
{
    public class DetailsModel : PageModel
    {
        private readonly ProjetAspCore.Data.ApplicationDbContext _context;

        public DetailsModel(ProjetAspCore.Data.ApplicationDbContext context, UserManager<IdentityUser> userManager)
        {
            _context = context;
        }

        private readonly UserManager<IdentityUser> _userManager;

        public Seance Seance { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {

            var userId = User.FindFirstValue(ClaimTypes.NameIdentifier);
            var profId = _context.Professeur.Where(e => e.User.Id == userId).FirstOrDefault().code_professeur;
            if (id == null)
            {
                return NotFound();
            }


            Seance = await _context.Seance.Include(e => e.Matiere)
                                            .Include(e => e.Abscences)
                                            .Include(e => e.Salle)
                                            .Include(e => e.Salle)
                                           .Include(e => e.Matiere.Filiere)
             .FirstOrDefaultAsync(m => m.code_seance == id);

            ViewData["Presence"] = _context.Abscence
                           .Where(a => a.seance.code_seance == id
                                && Seance.date_debut.Date == a.seance.Abscences.FirstOrDefault().date_abs.Date

                               )
                           .Include(e => e.etudiant)
                           .Include(F => F.etudiant.Filiere)
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
