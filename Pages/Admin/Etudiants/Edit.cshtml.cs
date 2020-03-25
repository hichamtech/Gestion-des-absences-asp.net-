using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using ProjetAspCore.Data;

using ProjetAspCore.Models;

namespace ProjetAspCore.Pages.Etudiants__referenceScriptLibraries
{
    public class EditModel : PageModel
    {
        private readonly ProjetAspCore.Data.ApplicationDbContext _context;

        public EditModel(ProjetAspCore.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Etudiant Etudiant { get; set; }


        public SelectList FilieresList { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Etudiant = await _context.Etudiant.FirstOrDefaultAsync(m => m.code_etudiant == id);
            FilieresList = new SelectList(_context.Filiere, "code_filiere", "libele_filiere");

            if (Etudiant == null)
            {
                return NotFound();
            }
            return Page();
        }

 
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Attach(Etudiant).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!EtudiantExists(Etudiant.code_etudiant))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return RedirectToPage("./Index");
        }

        private bool EtudiantExists(int id)
        {
            return _context.Etudiant.Any(e => e.code_etudiant == id);
        }
    }
}
