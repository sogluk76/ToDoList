using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using MyFruits.Data;
using MyFruits.Models;

namespace MyFruits.Areas.Fruits.Pages
{
    public class CreateModel : PageModel
    {
        private readonly MyFruits.Data.ApplicationDbContext _context;

        public CreateModel(MyFruits.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public Fruit Fruit { get; set; }
        

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
          if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Fruits.Add(Fruit);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
