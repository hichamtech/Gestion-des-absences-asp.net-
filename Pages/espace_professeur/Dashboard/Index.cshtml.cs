using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using ProjetAspCore.Models;

namespace ProjetAspCore.Page
{
    public class DashboardModel : PageModel
    {
        private readonly UserManager<IdentityUser> _userManager;
        private readonly ILogger<DashboardModel> _logger;


        private readonly ProjetAspCore.Data.ApplicationDbContext _context;
        public IList<Matiere> Matiere { get; set; }
        public IList<Abscence> Abscence { get; set; }

        public IList<Seance> Seances { get; set; }
        // public IList<Etudiant> Etudiant { get; set; }
        public DashboardModel(ILogger<DashboardModel> logger, UserManager<IdentityUser> userManager, ProjetAspCore.Data.ApplicationDbContext context)
        {
            _logger = logger;
            _context = context;
            _userManager = userManager;
        }
        public async Task OnGetAsync()
        {
            var userId = _userManager.GetUserId(User);
            var profId = _context.Professeur.Where(e => e.User.Id == userId).FirstOrDefault().code_professeur;

            //Matiéres info
            Matiere = await _context.Matiere
            .Include(c => c.Filiere)
            .Include(a => a.Seances)
            .Where(e => e.Professeurcode_professeur == profId)
            .ToListAsync();

            //Présence et Absence
            //presence list
            Abscence = _context.Abscence
                        .Where(e => e.professeurcode_professeur == profId)
                        .Include(s => s.etudiant)
                        .Include(a => a.seance)

                        .ToList();
            //absence liste
            /* ViewData["absence"] = (from Etudiant in _context.Etudiant
                                    where !_context.Abscence.Any(f => f.etudiantcode_etudiant == Etudiant.code_etudiant && f.professeurcode_professeur == profId)
                                    select Etudiant.nom).ToList();*/

            ViewData["absence"] = _context.Etudiant
                      .Where(c => !_context.Abscence
                  .Select(b => b.etudiantcode_etudiant)
                      .Contains(c.code_etudiant)
                      && c.Abscences.FirstOrDefault().professeurcode_professeur == profId
                      )
                      .Include(e => e.Filiere)
                      .Include(e => e.Abscences)
                      .ToList();

            /*  ViewData["absence"] = _context.Etudiant
                       .Where(c => !_context.Abscence
                   .Select(b => b.etudiantcode_etudiant)
                       .Contains(c.code_etudiant)).ToList();*/


            //Seance Liste
            Seances = _context.Seance
                    .Where(e => e.Matiere.Professeurcode_professeur == profId)
                    .Include(a => a.Abscences)
                    .Include(s => s.Salle)
                    .Include(m => Matiere)
                    .ToList();

            //       



        }
    }
}
