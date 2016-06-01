using System.Web.Mvc;
using DotWeb.Controller;
using ProcCore.Business.DB0;
using System.Collections.Generic;
using System.Linq;

namespace DotWeb.Controllers
{
    public class ArticlesController : WebUserController
    {
        public ActionResult List()
        {
            return View("Article_list");
        }
        public ActionResult Content001()
        {
            return View("Article_content001");
        }
        public ActionResult Content002()
        {
            return View("Article_content002");
        }
    }

}
