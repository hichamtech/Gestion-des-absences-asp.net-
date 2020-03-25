using ProjetAspCore.Data;

using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace ProjetAspCore.Pages.Etudiants
{
    public class FiliereNamePageModel
    {
    public SelectList FiliereNameSL { get; set; }
    public void PopulateDepartmentsDropDownList(ApplicationDbContext _context,
            object selectedDepartment = null)
        {
            var FiliereQuery = from d in _context.Filiere
                                   orderby d.libele_filiere // Sort by name.
                                   select d;

            FiliereNameSL = new SelectList(FiliereQuery.AsNoTracking(),
                        "code_filiere", "libele_filiere", selectedDepartment);
        }

    }
}