using Auth.AMF.Web.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace Auth.AMF.Web.Controllers
{
    [Route("conta")]
    public class AccountController : Controller
    {
        //[Route("criar-senha/{authHash:Guid}")]
        //public IActionResult CreatePassword(Guid authHash)
        [Route("criar-senha")]
        public IActionResult CreatePassword()
        {
            return View();
        }

        [HttpPost]
        [Route("criar-senha")]
        public IActionResult CreatePassword(CreatePasswordViewModel model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }
            return View();
        }
    }
}
