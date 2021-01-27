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
    public class IndexModel : PageModel
    {
        private readonly DrawMap.Models.DB.BasarsoftContext _context;

        public IndexModel(DrawMap.Models.DB.BasarsoftContext context)
        {
            _context = context;
        }

        public IList<User> User { get;set; }

        public async Task OnGetAsync()
        {
            User = await _context.User.ToListAsync();
        }
    }
}
