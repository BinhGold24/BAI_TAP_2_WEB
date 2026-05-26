using Microsoft.AspNetCore.Mvc;

namespace StudentManagement.Controllers
{
    public class HomeController : Controller
    {
        // Action 1: Index (Tương ứng với trang chủ)
        public IActionResult Index()
        {
            // Bỏ dòng chữ vào một cái "túi" tên là ViewBag.Message
            ViewBag.Message = "Welcome to ASP.NET MVC";

            // Trả về View (Giao diện HTML)
            return View();
        }

        // Action 2: About
        public IActionResult About()
        {
            ViewBag.Message = "Tên sinh viên: Nguyễn Đức Bình";
            return View();
        }

        // Action 3: Contact
        public IActionResult Contact()
        {
            ViewBag.Message = "Email của mình nb241006788@gmail.com";
            return View();
        }
    }
}