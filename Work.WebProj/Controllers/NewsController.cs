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
    }

}
