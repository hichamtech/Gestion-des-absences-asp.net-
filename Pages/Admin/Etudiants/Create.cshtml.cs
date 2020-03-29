using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using ProjetAspCore.Data;

using ProjetAspCore.Models;
using Microsoft.EntityFrameworkCore;


namespace ProjetAspCore.Pages.Etudiants__referenceScriptLibraries
{
    public class CreateModel : PageModel 
    {
        private readonly ProjetAspCore.Data.ApplicationDbContext _context;

        public CreateModel(ProjetAspCore.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        public SelectList FilieresList { get; set; }

        public IActionResult OnGet()
        {
            FilieresList = new SelectList(_context.Filiere, "code_filiere", "libele_filiere");

            return Page();
        }

        [BindProperty]
        public Etudiant Etudiant { get; set; }

    
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
             {
                 return Page();


             }
            
          
            _context.Etudiant.Add(Etudiant);
        
            await _context.SaveChangesAsync();

           return RedirectToPage("./Index");

       

    }
}
}