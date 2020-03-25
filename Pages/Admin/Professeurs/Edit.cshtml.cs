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

namespace ProjetAspCore.Pages.Professeur__referenceScriptLibraries
{
    public class EditModel : PageModel
    {
        private readonly ProjetAspCore.Data.ApplicationDbContext _context;

        public EditModel(ProjetAspCore.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Professeur Professeur { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Professeur = await _context.Professeur.FirstOrDefaultAsync(m => m.code_professeur == id);

            if (Professeur == null)
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

            _context.Attach(Professeur).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ProfesseurExists(Professeur.code_professeur))
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

        private bool ProfesseurExists(int id)
        {
            return _context.Professeur.Any(e => e.code_professeur == id);
        }
    }
}
