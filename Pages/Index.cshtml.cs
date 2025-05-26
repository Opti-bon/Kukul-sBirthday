using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

public class IndexModel : PageModel
{
    [BindProperty]
    public string PasswordInput { get; set; }

    public string Message { get; set; }

    public IActionResult OnPost()
    {
        const string CorrectPassword = "25-05-2025"; // Your new password

        if (PasswordInput == CorrectPassword)
        {
            return RedirectToPage("Secret");
        }
        else
        {
            Message = "Chi!! Chi!! Have some shame bro! Mistaking your own birthday! Tore asholey kuray ansee. Put it like (01-12-2025). Use Day-Month-Year format and use the current year not your birth year, bolod!!";
            return Page();
        }
    }
}
