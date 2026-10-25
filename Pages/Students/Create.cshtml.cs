using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using wt_lab5_5razor_vasileva.Data;
using wt_lab5_5razor_vasileva.Models;

namespace wt_lab5_5razor_vasileva.Pages.Students;

public class CreateModel : PageModel
{
    [BindProperty]
    public Student Student { get; set; } = new();

    public void OnGet()
    {
        // GET — просто показать форму
    }

    public IActionResult OnPost()
    {
        if (!ModelState.IsValid)
        {
            return Page();
        }

        // Автогенерация Id
        Student.Id = StudentStore.Students.Any()
            ? StudentStore.Students.Max(s => s.Id) + 1
            : 1;

        StudentStore.Students.Add(Student);

        return RedirectToPage("./Index");
    }
}