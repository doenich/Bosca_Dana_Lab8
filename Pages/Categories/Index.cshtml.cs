﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Bosca_Dana_Lab8.Data;
using Bosca_Dana_Lab8.Models;

namespace Bosca_Dana_Lab8.Pages.Categories
{
    public class IndexModel : PageModel
    {
        private readonly Bosca_Dana_Lab8.Data.Bosca_Dana_Lab8Context _context;

        public IndexModel(Bosca_Dana_Lab8.Data.Bosca_Dana_Lab8Context context)
        {
            _context = context;
        }

        public IList<Category> Category { get;set; }

        public async Task OnGetAsync()
        {
            Category = await _context.Category.ToListAsync();
        }
    }
}
