using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using ProjetAspCore.Data;

using ProjetAspCore.Models;

namespace ProjetAspCore.Pages.Etudiants__referenceScriptLibraries
{
    public class IndexModel : PageModel
    {
        private readonly ProjetAspCore.Data.ApplicationDbContext _context;

        public IndexModel(ProjetAspCore.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        public IList<Etudiant> Etudiant { get;set; }

        public int nbr_abs;

        public int taux_abs{get;set;}


        public async Task OnGet()
        {
            Etudiant =  await _context.Etudiant
            .Include(c => c.Filiere)
            .Include(a => a.Abscences)
            .AsNoTracking()
            .ToListAsync();

          //var IdEtd = _context.Etudiant.Select(i=>i.code_etudiant);
            //ViewData["test"] = _context.Etudiant.Select(i=>i.code_etudiant).ToList();
        
         //   nbr_abs = etudiant.Abscences.Count();
    
           // nbr_abs = _context.Abscence.Where(a => a.etudiantcode_etudiant == Etudiant.IndexOf()).Count();
        }
    }
}
