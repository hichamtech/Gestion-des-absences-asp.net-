using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using ProjetAspCore.Data;

using ProjetAspCore.Models;

namespace ProjetAspCore.Pages.Filieres__referenceScriptLibraries
{
    public class DeleteModel : PageModel
    {
        private readonly ProjetAspCore.Data.ApplicationDbContext _context;

        public DeleteModel(ProjetAspCore.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Filiere Filiere { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Filiere = await _context.Filiere.FirstOrDefaultAsync(m => m.code_filiere == id);

            if (Filiere == null)
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

            Filiere = await _context.Filiere.FindAsync(id);

            if (Filiere != null)
            {
                _context.Filiere.Remove(Filiere);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
