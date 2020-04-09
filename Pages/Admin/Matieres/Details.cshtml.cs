using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using ProjetAspCore.Data;

using ProjetAspCore.Models;

namespace ProjetAspCore.Pages.MAtieres__referenceScriptLibraries
{
    public class DetailsModel : PageModel
    {
        private readonly ProjetAspCore.Data.ApplicationDbContext _context;

        public DetailsModel(ProjetAspCore.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        public Matiere Matiere { get; set; }

        public Seance Seance { get; set; }


        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }


            //

            ViewData["idSeanceMatiere"] = _context.Seance.Where(s => s.Matierecode_matiere == id)
                                            .Include(s => s.Salle)
                                            .Include(a => a.Abscences)

                                            .ToList();
            /*  var DateSeanceMatiere =   _context.Seance
                                      .Where(s => s.Matierecode_matiere ==id)                               
                                     .Select(a => a.date_debut).ToList() ;*/

            ViewData["abs"] = _context.Abscence
                            .Where(a => a.seance.Matierecode_matiere == id)
                            .Include(e => e.etudiant)
                            .Include(F => F.etudiant.Filiere)
                            .Include(P => P.professeur)
                            .ToList();

            var idEtd = _context.Etudiant.Select(e => e.code_etudiant).ToList();

            /*ViewData["absence"] = from a in _context.Abscence
            where !idEtd.Contains(a.etudiantcode_etudiant) 
         
                 select a;     */
            var a = _context.Abscence.Select(s => s.etudiantcode_etudiant).ToList();

            /*ViewData["absence"] =    (from u in _context.Abscence.AsEnumerable()
                where u.seance.Matierecode_matiere == id &&
             !Matiere.F .Any(s => u.etudiantcode_etudiant.Contains(s))
             select new Etudiant {
              Name = u.FullName,
              Id = u.Id,
             }).Take(5).ToList();*/

            Matiere = await _context.Matiere
            .Include(s => s.Seances)
            .FirstOrDefaultAsync(m => m.code_matiere == id);

            if (Matiere == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
