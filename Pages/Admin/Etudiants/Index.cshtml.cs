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

namespace ProjetAspCore.Pages.Etudiants__referenceScriptLibraries
{
    public class IndexModel : PageModel
    {
        private readonly ProjetAspCore.Data.ApplicationDbContext _context;

        public IndexModel(ProjetAspCore.Data.ApplicationDbContext context)
        {
            _context = context;
        }


        public string NameSort { get; set; }
        public string DateSort { get; set; }
        public string CurrentFilter { get; set; }
        public string CurrentSort { get; set; }
        public PaginatedList<Etudiant> Etudiants { get; set; }

        public IList<Etudiant> Etudiant { get; set; }

        public int nbr_abs;

        public int taux_abs { get; set; }

        [BindProperty(SupportsGet = true)]
        public string SearchString { get; set; }
        public SelectList Filieres { get; set; }
        [BindProperty(SupportsGet = true)]
        public string EtudiantFiliere { get; set; }

        public async Task OnGet(string sortOrder, string searchString, string currentFilter, int? pageIndex)
        {

            CurrentSort = sortOrder;

            NameSort = String.IsNullOrEmpty(sortOrder) ? "prenom" : "filiere";
            DateSort = sortOrder == "Date" ? "date_desc" : "date_naissance";


            if (searchString != null)
            {
                pageIndex = 1;
            }
            else
            {
                searchString = currentFilter;
            }

            IQueryable<Etudiant> studentsIQ = from s in _context.Etudiant
                                              select s;

            if (!String.IsNullOrEmpty(searchString))
            {
                studentsIQ = studentsIQ.Where(s => s.nom.Contains(searchString)
                                       || s.prenom.Contains(searchString)
                                       || s.cin.Contains(searchString)
                                       );
            }

            switch (sortOrder)
            {
                case "prenom":
                    studentsIQ = studentsIQ.OrderByDescending(s => s.prenom);
                    break;
                case "filiere":
                    studentsIQ = studentsIQ.OrderBy(s => s.Filiere.libele_filiere);
                    break;
                case "date_naissance":
                    studentsIQ = studentsIQ.OrderByDescending(s => s.date_naissance);
                    break;
                default:
                    studentsIQ = studentsIQ.OrderBy(s => s.nom);
                    break;
            }
            int pageSize = 3;
            Etudiants = await PaginatedList<Etudiant>.CreateAsync(
                studentsIQ.AsNoTracking(), pageIndex ?? 1, pageSize);
            Etudiant = await studentsIQ
            .Include(c => c.Filiere)
            .Include(a => a.Abscences)
            .Include(d => d.Filiere.Matieres)
            .AsNoTracking()
            .ToListAsync();





            /*  nbr_abs = _context.Etudiant
                     .Where(c => !_context.Abscence
                    .Select(b => b.etudiantcode_etudiant)
                     .Contains(c.code_etudiant)


                     )
                     .Include(e => e.Filiere)
                     .Include(e => e.Abscences)
                     .Include(e => e.Filiere.Matieres)
                     .Count();*/

            /*  var IdEtd = _context.Etudiant.Select(i=>i.code_etudiant);

               nbr_abs = _context.Seance
                  .Where(c => !_context.Abscence
                 .Select(b => b.etudiantcode_etudiant)
                 .Contains(Etudiant.)

                  )

                  .Count();*/





            //ViewData["test"] = _context.Etudiant.Select(i=>i.code_etudiant).ToList();

            //   nbr_abs = etudiant.Abscences.Count();

            // nbr_abs = _context.Abscence.Where(a => a.etudiantcode_etudiant == Etudiant.IndexOf()).Count();
        }
    }
}
