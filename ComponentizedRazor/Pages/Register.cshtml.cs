using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Abstractions;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace ComponentizedRazor.Pages
{
    public class RegisterModel : PageModel
    {
        public void OnGet()
        {
        }

        public IActionResult OnPostRegister(string userEmail, string userPassword)
        {
            var x = userEmail;
            var y = userPassword;

            return Page();
        }
    }
}
