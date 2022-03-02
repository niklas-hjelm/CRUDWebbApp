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
    public class IndexModel : PageModel
    {
        private readonly CRUDWebbApp.DAL.CarsDbContext _context;

        public IndexModel(CRUDWebbApp.DAL.CarsDbContext context)
        {
            _context = context;
        }

        public IList<Car> Car { get;set; }

        public async Task OnGetAsync()
        {
            Car = await _context.Cars
                .Include(c => c.Make).ToListAsync();
        }
    }
}
