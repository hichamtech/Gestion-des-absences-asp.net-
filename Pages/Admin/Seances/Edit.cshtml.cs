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

namespace ProjetAspCore.Pages.Seances__referenceScriptLibraries
{
    public class EditModel : PageModel
    {
        private readonly ProjetAspCore.Data.ApplicationDbContext _context;

        public EditModel(ProjetAspCore.Data.ApplicationDbContext context)
        {
            _context = context;
        }
        public SelectList MatieresList { get; set; }
        public SelectList SallesList { get; set; }

        [BindProperty]
        public Seance Seance { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            MatieresList = new SelectList(_context.Matiere, "code_matiere", "libele_matiere");
            SallesList = new SelectList(_context.Salle, "code_salle", "numero_salle");

            Seance = await _context.Seance.FirstOrDefaultAsync(m => m.code_seance == id);

            if (Seance == null)
            {
                return NotFound();
            }
            return Page();
        }

        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Attach(Seance).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!SeanceExists(Seance.code_seance))
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

        private bool SeanceExists(int id)
        {
            return _context.Seance.Any(e => e.code_seance == id);
        }
    }
}
