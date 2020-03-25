using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using ProjetAspCore.Data;

using ProjetAspCore.Models;

namespace ProjetAspCore.PagesSalle
{
    public class DetailsModel : PageModel
    {
        private readonly ProjetAspCore.Data.ApplicationDbContext _context;

        public DetailsModel(ProjetAspCore.Data.ApplicationDbContext context)
        {
            _context = context;
        }

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
    }
}
