using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace QuanLyBanHang.Controllers
{
    public class GioHangController : Controller
    {
        // GET: GioHang
        public ActionResult XemGioHang()
        {
            return View();
        }
        // GET: GioHang
        public ActionResult GioHangPartial()
        {
            return PartialView();
        }
    }
}