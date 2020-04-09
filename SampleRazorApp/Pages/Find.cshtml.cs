using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using SampleRazorApp.Data;
using SampleRazorApp.Models;

namespace SampleRazorApp.Pages
{
    public class FindModel : PageModel
    {
        private readonly SampleRazorAppContext _context;
        public IList<Person> People { get; set; }

        public FindModel(SampleRazorAppContext context)
        {
            _context = context;
        }

        public async Task OnGetAsync()
        {
            IQueryable<Person> result = from p in _context.Person select p;
            People = await result.ToListAsync();
        }

        public async Task OnPostAsync(string Find)
        {
            IQueryable<Person> result = from p in _context.Person where p.Name == Find select p;
            People = await result.ToListAsync();
        }
    }
}