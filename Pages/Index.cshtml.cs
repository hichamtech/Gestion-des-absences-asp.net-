﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using ProjetAspCore.Models;
namespace ProjetAspCore.Pages
{
    public class IndexModel : PageModel
    {

        private readonly ProjetAspCore.Data.ApplicationDbContext _context;

        private readonly ILogger<IndexModel> _logger;

        [BindProperty]
        [Display(Name = "Code Rfid")]
        [Required]
        public string Rfid { get; set; }

        public string Message { get; set; }

        public IndexModel(ILogger<IndexModel> logger, ProjetAspCore.Data.ApplicationDbContext context)
        {
            _logger = logger;
            _context = context;

        }

        public void OnGet()
        {


        }

        public async Task<IActionResult> OnPostAsync()
        {

            if (!ModelState.IsValid)
            {
                return Page();
            }



            var idEtudiant = _context.Etudiant.Where(e => e.code_rfid == Rfid).FirstOrDefault().code_etudiant;


            var codeF = _context.Etudiant.Where(e => e.code_rfid == Rfid).FirstOrDefault().Filierecode_filiere;
            var codeM = _context.Matiere.Where(m => m.Filierecode_filiere == codeF).FirstOrDefault().code_matiere;
            var codeP = _context.Matiere.Where(p => p.Filierecode_filiere == codeF).FirstOrDefault().Professeurcode_professeur;
            var codeS = _context.Seance.Where(s => s.Matierecode_matiere == codeM).FirstOrDefault().code_seance;


            if (!string.IsNullOrEmpty(Rfid))

            {
                var abs = new Abscence() { date_abs = DateTime.Now, etudiantcode_etudiant = idEtudiant, seancecode_seance = codeS, professeurcode_professeur = codeP };
                _context.Abscence.Add(abs);
                await _context.SaveChangesAsync();
                Message = "Checked";

            }
            else
            {
                Message = "Erreur";

            }



            return Page();



        }
    }
}