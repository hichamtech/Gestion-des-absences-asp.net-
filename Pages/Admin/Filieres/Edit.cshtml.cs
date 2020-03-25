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

namespace ProjetAspCore.Pages.Filieres__referenceScriptLibraries
{
    public class EditModel : PageModel
    {
        private readonly ProjetAspCore.Data.ApplicationDbContext _context;

        public EditModel(ProjetAspCore.Data.ApplicationDbContext context)
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

   
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Attach(Filiere).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!FiliereExists(Filiere.code_filiere))
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

        private bool FiliereExists(int id)
        {
            return _context.Filiere.Any(e => e.code_filiere == id);
        }
    }
}
