#nullable disable
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using CRUDWebbApp.DAL;
using CRUDWebbApp.DAL.Models;

namespace CRUDWebbApp.Pages.Cars
{
    public class DetailsModel : PageModel
    {
        private readonly CRUDWebbApp.DAL.CarsDbContext _context;

        public DetailsModel(CRUDWebbApp.DAL.CarsDbContext context)
        {
            _context = context;
        }

        public Car Car { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Car = await _context.Cars
                .Include(c => c.Make).FirstOrDefaultAsync(m => m.Id == id);

            if (Car == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
