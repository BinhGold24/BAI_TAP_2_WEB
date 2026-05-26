using Microsoft.AspNetCore.Mvc;

namespace Bai2.Controllers
{
    public class ProductController : Controller
    {
        // Action 1: Detail
        public IActionResult Detail(int? id)
        {
            if (id == null)
            {
                ViewBag.Message = "Lỗi: Bạn chưa cung cấp ID của sản phẩm trên URL!";
            }
            else
            {
                ViewBag.Message = $"Product ID = {id}";
            }

            return View(); // Trả về giao diện có chứa thanh menu
        }

        // Action 2: Category
        public IActionResult Category(string name)
        {
            if (string.IsNullOrWhiteSpace(name))
            {
                ViewBag.Message = "Lỗi: Bạn chưa cung cấp tên danh mục (name)!";
            }
            else
            {
                ViewBag.Message = $"Category = {name}";
            }

            return View(); // Trả về giao diện có chứa thanh menu
        }
    }
}