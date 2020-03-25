using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using ProjetAspCore.Data;

using ProjetAspCore.Models;

namespace ProjetAspCore.Pages.Filieres__referenceScriptLibraries
{
    public class CreateModel : PageModel
    {
        private readonly ProjetAspCore.Data.ApplicationDbContext _context;

        public CreateModel(ProjetAspCore.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public Filiere Filiere { get; set; }

 
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Filiere.Add(Filiere);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
