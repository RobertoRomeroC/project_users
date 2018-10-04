using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Threading.Tasks;
using UserAdmin.Data;
using UserAdmin.Data.Entities;
using UserAdmin.ViewModels;

namespace UserAdmin.Controllers
{
    public class AppController : Controller
    {
        private readonly UserAdminContext _context;
        private readonly IUserAdminRepository _repository;

        public AppController(UserAdminContext context, IUserAdminRepository repository)
        {
            _context = context;
            _repository = repository;
        }

        public async Task<IActionResult> Index()
        {
            return View(await _context.Users.ToListAsync());
        }

        [HttpGet("management")]
        public IActionResult Management()
        {
            ViewBag.Title = "Management Users";

            return View();
        }

        [HttpPost("management")]
        public async Task<IActionResult> Management(UserViewModel uservm)
        {
            using (var context = new UserAdminContext())
            {
                var users = await context.Users.Select(u => new SelectListItem
                {
                    Users = uservm.Users,
                    Mail = uservm.Mail,
                    Password = uservm.Password,
                    Sex = uservm.Sex,
                    Status = uservm.Status
                }).ToListAsync();
                ViewBag.Users = users;
            }
            return View();


            var user = new User
            {
                Users = uservm.Users,
                Mail = uservm.Mail,
                Password = uservm.Password,
                Sex = uservm.Sex,
                Status = uservm.Status
            };

            _context.Add(user);

            _context.SaveChanges();

            return View();
        }

        public IActionResult UsersList()
        {
            var results = _repository.GetAllUsers();

            return View(results);
        }

       
    }
}
