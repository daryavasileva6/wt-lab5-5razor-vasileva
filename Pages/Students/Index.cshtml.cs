using Microsoft.AspNetCore.Mvc.RazorPages;
using wt_lab5_5razor_vasileva.Data;
using wt_lab5_5razor_vasileva.Models;

namespace wt_lab5_5razor_vasileva.Pages.Students;

public class IndexModel : PageModel
{
    public List<Student> Students { get; set; } = new();

    public void OnGet()
    {
        Students = StudentStore.Students;
    }
}