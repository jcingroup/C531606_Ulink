using System.Web.Mvc;
using DotWeb.Controller;
using ProcCore.Business.DB0;
using System.Collections.Generic;
using System.Linq;

namespace DotWeb.Controllers
{
    public class NewsController : WebUserController
    {
        public ActionResult List()
        {
            return View("News_list");
        }
        public ActionResult Content001()
        {
            return View("News_content001");
        }
        public ActionResult Content002()
        {
            return View("News_content002");
        }
        public ActionResult Content003()
        {
            return View("News_content003");
        }
        public ActionResult Content004()
        {
            return View("News_content004");
        }
    }

}
