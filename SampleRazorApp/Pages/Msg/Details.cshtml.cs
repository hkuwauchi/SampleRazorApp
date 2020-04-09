using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using SampleRazorApp.Data;
using SampleRazorApp.Models;

namespace SampleRazorApp.Pages.Msg
{
    public class DetailsModel : PageModel
    {
        private readonly SampleRazorApp.Data.SampleRazorAppContext _context;

        public DetailsModel(SampleRazorApp.Data.SampleRazorAppContext context)
        {
            _context = context;
        }

        public Message Message { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Message = await _context.Message.FirstOrDefaultAsync(m => m.MessageId == id);

            if (Message == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
