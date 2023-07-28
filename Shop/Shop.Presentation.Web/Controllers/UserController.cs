using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Shop.Presentation.Web.Areas.Identity.Data;
using System.Linq;
using System.Threading.Tasks;

namespace Shop.Presentation.Web.Controllers
{
    [Authorize(Roles = "Admin")]
    [Route("User")]
    public class UserController : Controller
    {
        private readonly UserManager<ShopUser> _userManager;
        private readonly RoleManager<IdentityRole> _roleManager;

        public UserController(
            UserManager<ShopUser> userManager,
            RoleManager<IdentityRole> roleManager
            )
        {
            _userManager = userManager;
            _roleManager = roleManager;
        }

        [HttpGet]
        [Route("Index")]
        public async Task<IActionResult> Index()
        {
            var roles = _roleManager.Roles.Select(x => x.Name).ToList();
            //await _roleManager.CreateAsync(new IdentityRole(Role.Manager.ToString()));
            //roles = _roleManager.Roles.Select(x => x.Name).ToList();
            var users = _userManager.Users.ToList();

            return Ok();
        }
    }
}
