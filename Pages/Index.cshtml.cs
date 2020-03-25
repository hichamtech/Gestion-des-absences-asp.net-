﻿using System;
using System.Collections.Generic;
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

        public IndexModel(ILogger<IndexModel> logger,ProjetAspCore.Data.ApplicationDbContext context)
        {
            _logger = logger;
            _context = context;

        }

        public void OnGet()
        {
   
            
        }
    }
}