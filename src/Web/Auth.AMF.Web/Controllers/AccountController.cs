using Auth.AMF.Web.Services;
using Auth.AMF.Web.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace Auth.AMF.Web.Controllers
{
    [Route("conta")]
    public class AccountController : Controller
    {
        readonly IAccountService _accountService;

        public AccountController(IAccountService accountService)
        {
            _accountService = accountService;
        }

        //[Route("criar-senha/{authHash:Guid}")]
        //public IActionResult CreatePassword(Guid authHash)
        [Route("criar-senha")]
        public async Task<IActionResult> CreatePassword()
        {
            await _accountService.GetData(System.Guid.NewGuid());
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
