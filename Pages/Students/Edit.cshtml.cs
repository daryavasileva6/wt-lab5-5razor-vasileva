using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using wt_lab5_5razor_vasileva.Data;
using wt_lab5_5razor_vasileva.Models;

namespace wt_lab5_5razor_vasileva.Pages.Students;

public class EditModel : PageModel
{
    [BindProperty]
    public Student Student { get; set; } = new();

    public IActionResult OnGet(int id)
    {
        var existing = StudentStore.Students.FirstOrDefault(s => s.Id == id);
        if (existing == null)
            return NotFound();

        Student = existing;
        return Page();
    }

    public IActionResult OnPost()
    {
        if (!ModelState.IsValid)
            return Page();

        var existing = StudentStore.Students.FirstOrDefault(s => s.Id == Student.Id);
        if (existing == null)
            return NotFound();

        existing.FullName = Student.FullName;
        existing.Group = Student.Group;
        existing.AverageGrade = Student.AverageGrade;
        existing.EnrollmentYear = Student.EnrollmentYear;
        existing.Email = Student.Email;

        return RedirectToPage("./Index");
    }
}