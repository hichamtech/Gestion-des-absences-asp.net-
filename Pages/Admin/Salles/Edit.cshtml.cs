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

namespace ProjetAspCore.PagesSalle
{
    public class EditModel : PageModel
    {
        private readonly ProjetAspCore.Data.ApplicationDbContext _context;

        public EditModel(ProjetAspCore.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Salle Salle { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Salle = await _context.Salle.FirstOrDefaultAsync(m => m.code_salle == id);

            if (Salle == null)
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

            _context.Attach(Salle).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!SalleExists(Salle.code_salle))
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

        private bool SalleExists(int id)
        {
            return _context.Salle.Any(e => e.code_salle == id);
        }
    }
}
