using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using ProjetAspCore.Data;

using ProjetAspCore.Models;

namespace ProjetAspCore.Pages.MAtieres__referenceScriptLibraries
{
    public class CreateModel : PageModel
    {
        private readonly ProjetAspCore.Data.ApplicationDbContext _context;

        public CreateModel(ProjetAspCore.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        public SelectList FilieresList { get; set; }
        public SelectList ProfesseursList { get; set; }

        public IActionResult OnGet()
        {
            FilieresList = new SelectList(_context.Filiere, "code_filiere", "libele_filiere");
            ProfesseursList = new SelectList(_context.Professeur, "code_professeur", "nom");

            return Page();
        }

        [BindProperty]
        public Matiere Matiere { get; set; }
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }


            _context.Matiere.Add(Matiere);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
