#nullable disable
using CRUDWebbApp.DAL;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using CRUDWebbApp.DAL.Models;

namespace CRUDWebbApp.Pages.Cars;

public class CreateModel : PageModel
{
    private readonly CarsDbContext _context;

    public CreateModel(CarsDbContext context)
    {
        _context = context;
    }

    public IActionResult OnGet()
    {
        ViewData["MakeId"] = new SelectList(_context.Makes, "Id", "Name");
        return Page();
    }

    [BindProperty]
    public Car Car { get; set; }

    // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
    public async Task<IActionResult> OnPostAsync()
    {
        //TODO: Fix when all tables are populated

        Car.Make = _context.Makes.FirstOrDefault(m => m.Id == Car.MakeId);
        Car.Dealers = new List<Dealer>();

        //if (!ModelState.IsValid)
        //{
        //    return Page();
        //}

        _context.Cars.Add(Car);
        await _context.SaveChangesAsync();

        return RedirectToPage("./Index");
    }
}

