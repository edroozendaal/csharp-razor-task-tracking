using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Tasker
{
    public class CreateTaskModel : PageModel
    {
        public void OnGet()
        {

        }

        public IActionResult OnPost()
        {
            return RedirectToPage("Index");
        }

        [BindProperty]
        public Task NewTask { get; set; }
    }

    public class CreateTask { }
}