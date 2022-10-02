using Microsoft.AspNetCore.Mvc;
using NguyenGiaNguyenBTH.Models;
namespace NguyenGiaNguyenBTH.Controllers;
{
    public class StringProcessController : Controller
    {
        StringProcess strPro = new StringProcess();
        public IActionResult Xulychuoi()
        {
            return  View();
        }
        [HttpPost]
        public IActionResult xulychuoi(string strInput)
        {
            string strResult = strPro.XoaBoKhoangTrang(strInput);
            ViewBag.thongBao = strResult;
            return View();
            
        }    
    }

}