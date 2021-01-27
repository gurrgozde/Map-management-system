using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using DrawMap.Models.DB;

namespace DrawMap.Pages
{
    public class DetailsModel : PageModel
    {
        private readonly DrawMap.Models.DB.BasarsoftContext _context;

        public DetailsModel(DrawMap.Models.DB.BasarsoftContext context)
        {
            _context = context;
        }

        public User User { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            User = await _context.User.FirstOrDefaultAsync(m => m.Userid == id);

            if (User == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
