using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class NewsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Blank() {
            News itemNew = new News();

            itemNew.titel = "ค่าฝุ่นละออง PM 2.5 เกินมาตรฐาน 20 พื้นที่";
            itemNew.desc = "/ พบร่างสมาชิกสภาเทศบาลเสียชีวิตในรถ / จนท.เลือกตั้งเอกวาดอร์ตรวจโควิด-19 ก่อนเลือกตั้ง";

            NewsList newsList = new NewsList();
            newsList.data.Add(new News {
                titel="Test",
                desc="T.akjsdsad lasd  lasdnn  asdlkjnasda"
            });
            return View(itemNew);
        }
    }
}