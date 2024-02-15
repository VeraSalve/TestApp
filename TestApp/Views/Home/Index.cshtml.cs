using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using TestApp.Data;
using TestApp.Models;

namespace TestApp.Views.Home
{
    public class IndexModel : PageModel
    {
        private readonly TestApp.Data.TestAppContext _context;

        public IndexModel(TestApp.Data.TestAppContext context)
        {
            _context = context;
        }

       
    }
}
