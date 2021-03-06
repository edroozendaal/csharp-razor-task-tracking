﻿using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Tasker.Pages
{
    public class CreateTaskModel : PageModel
    {
        private ApplicationDbContext _context;

        public CreateTaskModel(ApplicationDbContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Task NewTask { get; set; }

        public void OnGet()
        {

        }

        public IActionResult OnPost()
        {
            _context.Tasks.Add(NewTask);
            _context.SaveChanges();
            return RedirectToPage("Index");
        }
    }
}