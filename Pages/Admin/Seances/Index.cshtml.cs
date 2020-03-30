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
    public class IndexModel : PageModel
    {
        private readonly ProjetAspCore.Data.ApplicationDbContext _context;

        public IndexModel(ProjetAspCore.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        public SelectList MatieresList { get; set; }
        public SelectList SallesList { get; set; }
        public IList<Seance> Seance { get;set; }
        
        [BindProperty]
        public Seance SeanceCreate { get; set; }


        public async Task OnGetAsync()
        {

           
            MatieresList = new SelectList(_context.Matiere, "code_matiere", "libele_matiere");
            SallesList = new SelectList(_context.Salle, "code_salle", "numero_salle");
            Seance = await _context.Seance
            .Include(c => c.Matiere)
            .Include(s => s.Salle)
            .AsNoTracking()
            .ToListAsync();

        }
        
        public IActionResult OnGetEvents(){

            var seances = _context.Seance.Select(e => new 
            {
                code_seance = e.code_seance,
                libele_seance = e.libele_seance,
                date_debut = e.date_debut,
                date_fin = e.date_fin,
                matiere = e.Matiere.libele_matiere,
                code_matiere = e.Matiere.code_matiere,
                salle = e.Salle.numero_salle,
                code_salle = e.Salle.code_salle,
                filliere = e.Matiere.Filiere.libele_filiere,
                description = " Salle: " + e.Salle.numero_salle + " | Matiere: " + e.Matiere.libele_matiere 
                                + " | Filliere: "  + e.Matiere.Filiere.libele_filiere

            }).ToList();
            return new JsonResult(seances);
        }

         
          public async Task<IActionResult> OnPostCreateAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Seance.Add(SeanceCreate);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }

         public JsonResult OnPostDelete(int? id)
        {
          var status = false;
        
    
        var v = _context.Seance.Where(a => a.code_seance == id).FirstOrDefault();
        if (v != null)
        {
            _context.Seance.Remove(v);
            _context.SaveChanges();
            status = true;
        
         }
            return new JsonResult (new { status = status});
        }
        
/*    public JsonResult OnPostAjouter()
    {
     var status = false;
    
        if (SeanceCreate.code_seance > 0)
        {
            //Update the event
            var v = _context.Seance.Where(a => a.code_seance == SeanceCreate.code_seance).FirstOrDefault();
            if (v != null)
            {
                v.libele_seance = SeanceCreate.libele_seance;
                v.date_debut = SeanceCreate.date_debut;
                v.date_fin = SeanceCreate.date_fin;
                v.Matierecode_matiere = SeanceCreate.Matiere.code_matiere;
                v.Sallecode_salle = SeanceCreate.Salle.code_salle;
            }
         }
         else
        {
            _context.Seance.Add(SeanceCreate);
        }
        _context.SaveChanges();
        status = true;
     
    
        return  new JsonResult(new {status = status});
     

       
        }
*/




        
    }
}
