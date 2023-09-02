using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using WebApplication2.Model;
using WebApplication2.Service.UserService;
namespace Shero.Pages
{
    public class showUsersModel : PageModel
    {
        public void OnGet()
        {

        }
        [BindProperty]
        public User User { get; set; }
        private UserService _userService;
        //dependency injection
      

      
        //when u click creat, that means a method is called, fx to create a user.
        public IActionResult OnPost()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }
            _userService.create(User);
            return Page();
        }
    }
}

