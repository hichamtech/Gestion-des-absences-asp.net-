using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using ProjetAspCore.Data;
using System.Text.Json;
using ProjetAspCore.Models;

namespace ProjetAspCore.Pages.Seances__referenceScriptLibraries
{
    public class CreateModel : PageModel
    {
        private readonly ProjetAspCore.Data.ApplicationDbContext _context;

        public CreateModel(ProjetAspCore.Data.ApplicationDbContext context)
        {
            _context = context;
        }
        public SelectList MatieresList { get; set; }
        public SelectList SallesList { get; set; }


        public IActionResult OnGet()
        {
            MatieresList = new SelectList(_context.Matiere, "code_matiere", "libele_matiere");
            SallesList = new SelectList(_context.Salle, "code_salle", "numero_salle");


            return Page();
        }

        [BindProperty]
        public Seance Seance { get; set; }

        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Seance.Add(Seance);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
       
    }
}
