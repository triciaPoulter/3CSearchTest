using System.Collections.Generic;
using System.IO;
using System.Web.Mvc;
using Newtonsoft.Json;
using SearchTest.Models;

namespace SearchTest.Controllers
{
    public class SearchController : Controller
    {
        // GET: Search
        public ActionResult Search()
        {
           var search = new Search()
            {
               UserName = "valor-software",
               Location = "Kharviv",
               Avatar = "avatar_url",
               Name = "Valor Software"
           };

            return View();
        }

        [HttpPost]
        public JsonResult GetProfile()
        {
            using (var r =
                new StreamReader("C:\\Users\\Tricia\\source\\repos\\SearchTest\\SearchTest\\Scripts\\testFile.json"))
            {
                string json = r.ReadToEnd();
                var jsonObj = JsonConvert.DeserializeObject<RootObject>(json);
            }
            return Json(new { Search = Search() }, JsonRequestBehavior.AllowGet);

        } 
    }
}