using Microsoft.AspNetCore.Mvc;
using NguyenGiaNguyenBTH.Models.Process;

namespace NguyenGiaNguyenBTH.Controllers
{
    public class DemoController : Controller
    {   
        GiaiPhuongTrinh gpt = new GiaiPhuongTrinh();
        public IActionResult Index()
        {
            return View();
        }
        // nhận được dữ liệu từ view gửi lên 
        [HttpPost]
        public IActionResult Index(string heSoA,string heSoB)
        {
            double a = Convert.ToDouble(heSoA);
            double b = Convert.ToDouble(heSoB);
            string message = gpt.GiaiPhuongTrinhBacNhat(a,b);
            ViewBag.mess = message;
            return View();
        }
        [HttpPost]
         public IActionResult Create(string heSoA, string heSoB, string heSoC)
      {
        // ep kieu du lieu cua tham so
        double a = Convert.ToDouble(heSoA);
        double b = Convert.ToDouble(heSoB);
        double c = Convert.ToDouble(heSoC);
        string thongBao = gpt.GiaiPhuongTrinhBacHai(a, b, c);
        ViewBag.abc= "Kết quả" + thongBao ; 
        return View();
      }
    }   
}


