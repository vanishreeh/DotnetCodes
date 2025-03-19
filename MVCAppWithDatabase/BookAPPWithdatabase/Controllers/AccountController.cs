using BookAPPWithdatabase.constants;
using BookAPPWithdatabase.ViewModels;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace BookAPPWithdatabase.Controllers
{
    public class AccountController : Controller
    {
        readonly UserManager<IdentityUser> _userManager;
        readonly SignInManager<IdentityUser> _signInManger;
        public AccountController(UserManager<IdentityUser> manager,SignInManager<IdentityUser> signInManager)
        {
            _userManager = manager;
            _signInManger = signInManager;

        }
        [HttpGet]
        public IActionResult Register()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Register(RegisterViewModel user)
        {
            if (ModelState.IsValid)
            {
                var createdUser = new IdentityUser { UserName = user.Email, Email = user.Email };
                var result = await _userManager.CreateAsync(createdUser, user.Password);
                if (result.Succeeded)
                {
                    await _userManager.AddToRoleAsync(createdUser, Role.User);
                    return RedirectToAction("LogIn");
                }
                foreach (var error in result.Errors)
                {
                    ModelState.AddModelError(string.Empty, error.Description);
                }
            }
            return View(user);
        }
        [HttpGet]
        public IActionResult LogIn()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult>LogIn(LoginViewModel loginModel)
        {
            if (ModelState.IsValid)
            {
                var result = await _signInManger.PasswordSignInAsync(loginModel.Email, loginModel.Password, loginModel.RememberMe, false);
               if (result.Succeeded)
                {
                    return RedirectToAction("Privacy", "Home");
                }
                ModelState.AddModelError("", "LoginFailed");
                    }
            return View(loginModel);
        }
        public async Task<IActionResult> LogOut()
        {
           await _signInManger.SignOutAsync();
            return RedirectToAction("LogIn");
        }

    }
    //41776008-6086-4dbf-b923-2879a6680b9a
}
