using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using wt_lab5_5razor_vasileva.Data;
using wt_lab5_5razor_vasileva.Models;

namespace wt_lab5_5razor_vasileva.Pages.Students;

public class DetailsModel : PageModel
{
    public Student? Student { get; set; }

    public IActionResult OnGet(int id)
    {
        Student = StudentStore.Students.FirstOrDefault(s => s.Id == id);
        if (Student == null)
            return NotFound();
        return Page();
    }
}