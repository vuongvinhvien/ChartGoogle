using ChartGoogle.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ChartGoogle.Controllers
{

    public class ChartController : Controller
    {
        // GET: Chart
        public ActionResult Index()
        {
            return View();
        }
        /// <summary>
        /// Code lấy dữ liệu, trả về kiểu JSON
        /// </summary>
        /// <returns>JSON Data</returns>
        [HttpGet]
        public JsonResult GetJsonData()
        {
            Random r = new Random();
            var list = new List<Lop>();
            for (int i = 1; i <= 12; i++)
            {
                list.Add(new Lop { TenLop = "LỚP " + i, SoLuongSV = i * 5, XepHang = i * r.Next(1, 9) });
            }
            return Json(list, JsonRequestBehavior.AllowGet);
        }
    }

}