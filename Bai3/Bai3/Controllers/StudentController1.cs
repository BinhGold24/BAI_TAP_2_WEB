using Microsoft.AspNetCore.Mvc;

namespace StudentManagement.Controllers
{
    public class StudentController : Controller
    {
        public IActionResult Info()
        {
            // 1. Dùng ViewBag cho Name
            ViewBag.Name = "Nguyễn Đức Bình";

            // 2. Dùng ViewData cho Age
            ViewData["Age"] = 20;

            // 3. Dùng Model cho Major
            string major = "KHMT";

            // Trả về View và truyền biến major sang dưới dạng Model
            // Lưu ý: Phải dùng cú pháp model: major để hệ thống không nhầm chuỗi "CNTT" là tên của một file giao diện.
            return View(model: major);
        }
    }
}