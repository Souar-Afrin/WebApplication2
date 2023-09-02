using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using WebApplication2.Model;
using WebApplication2.Service.UserService;

namespace WebApplication2.Pages.UserPage
{
    public class CreateUserModel : PageModel
    {
        [BindProperty]
        public User User { get; set; }
        private UserService _userService;
        //dependency injection
        public CreateUserModel(UserService userService)
        {
            _userService = userService;
        }

        //to call the page when you click on the botton on the nav bar
        //it reads an html page and show it on the screen 
        public IActionResult OnGet()
        {
            return Page();
        }
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
