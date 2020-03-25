using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using ProjetAspCore.Data;

using ProjetAspCore.Models;

namespace ProjetAspCore.Pages.Etudiants__referenceScriptLibraries
{
    public class DeleteModel : PageModel
    {
        private readonly ProjetAspCore.Data.ApplicationDbContext _context;

        public DeleteModel(ProjetAspCore.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Etudiant Etudiant { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Etudiant = await _context.Etudiant.FirstOrDefaultAsync(m => m.code_etudiant == id);

            if (Etudiant == null)
            {
                return NotFound();
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Etudiant = await _context.Etudiant.FindAsync(id);

            if (Etudiant != null)
            {
                _context.Etudiant.Remove(Etudiant);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
