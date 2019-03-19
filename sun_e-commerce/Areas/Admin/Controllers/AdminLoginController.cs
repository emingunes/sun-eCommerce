using Model;
using System.Linq;
using System.Web.Mvc;

namespace sun_e_commerce.Areas.Admin.Controllers
{
    public class AdminLoginController : Controller
    {
        // GET: Admin/AdminLogin
        //globalde var kullanamadığım için;
        sunDbContext db = new sunDbContext();
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Index(string Email, string Password)
        {
            var data = db.Users.Where(x => x.Email == Email && x.Password == Password && x.IsActive == true && x.IsAdmin == true).ToList();
            if (data.Count == 1)
            {
                //giriş başarılı
                Session["AdminLoginUser"] = data.FirstOrDefault();

                return Redirect("/Admin/Default");

            }
            else
            {
                return Redirect("/AdminLogin");


            }
        }
    }
}