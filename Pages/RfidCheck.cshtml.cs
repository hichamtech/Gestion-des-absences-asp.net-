using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using ProjetAspCore.Models;

using Microsoft.AspNetCore.Mvc.Rendering;
using System.ComponentModel.DataAnnotations;

namespace ProjetAspCore.Pages
{
    public class RfidCheckModel : PageModel

    {
    private readonly ProjetAspCore.Data.ApplicationDbContext _context;
   
  public RfidCheckModel(ProjetAspCore.Data.ApplicationDbContext context)
        {
            _context = context;
        }


        [BindProperty]  
        [Display(Name = "Code Rfid")]
        public string Rfid {get;set;}



        public void OnGet()
        {
      
        }
        public async  Task<IActionResult> OnPostAsync(){

            if (!ModelState.IsValid)
            {
                return Page();
            }
        var idEtudiant =   _context.Etudiant.Where(e => e.code_rfid== Rfid).FirstOrDefault().code_etudiant;
 
        var codeF = _context.Etudiant.Where(e => e.code_rfid== Rfid).FirstOrDefault().Filierecode_filiere;
        var codeM =   _context.Matiere.Where(m =>m.Filierecode_filiere == codeF ).FirstOrDefault().code_matiere;
        var codeP =  _context.Matiere.Where(p =>p.Filierecode_filiere == codeF ).FirstOrDefault().Professeurcode_professeur;
         var codeS = _context.Seance.Where(s => s.Matierecode_matiere == codeM).FirstOrDefault().code_seance;

            var abs = new Abscence() { date_abs = DateTime.Now,etudiantcode_etudiant = idEtudiant,seancecode_seance = codeS ,professeurcode_professeur = codeP};


            _context.Abscence.Add(abs);
           await _context.SaveChangesAsync();

        return RedirectToPage("./RfidCheck");


        }
    }
}
