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
            People = await _context.Person.ToListAsync();
        }

        public async Task OnPostAsync(string Find)
        {
            People = await _context.Person.Where(c => c.Name == Find).ToListAsync();
        }
    }
}