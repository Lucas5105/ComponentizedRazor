using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace ComponentizedRazor.Pages
{
    public class LoginModel : PageModel
    {
        public void OnGet()
        {
        }

        public IActionResult OnPostLogin(string userEmail, string userPassword)
        {
            var x = userEmail;
            var y = userPassword;

            return Page();
        }
    }
}
