using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using ProjetAspCore.Data;

using ProjetAspCore.Models;

namespace ProjetAspCore.Pages.Abscences__referenceScriptLibraries
{
    public class DetailsModel : PageModel
    {
        private readonly ProjetAspCore.Data.ApplicationDbContext _context;

        public DetailsModel(ProjetAspCore.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        public Abscence Abscence { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Abscence = await _context.Abscence.FirstOrDefaultAsync(m => m.code_abs == id);

            if (Abscence == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
