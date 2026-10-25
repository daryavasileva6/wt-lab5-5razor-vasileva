using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using wt_lab5_5razor_vasileva.Data;
using wt_lab5_5razor_vasileva.Models;

namespace wt_lab5_5razor_vasileva.Pages.Students;

public class DeleteModel : PageModel
{
    public IActionResult OnPost(int id)
    {
        var student = StudentStore.Students.FirstOrDefault(s => s.Id == id);
        if (student != null)
            StudentStore.Students.Remove(student);
        return RedirectToPage("./Index");
    }
}