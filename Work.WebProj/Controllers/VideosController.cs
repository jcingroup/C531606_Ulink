using System.Web.Mvc;
using DotWeb.Controller;
using ProcCore.Business.DB0;
using System.Collections.Generic;
using System.Linq;

namespace DotWeb.Controllers
{
    public class VideosController : WebUserController
    {
        public ActionResult List()
        {
            return View("Video_list");
        }
        public ActionResult Content001()
        {
            return View("Video_content001");
        }
    }

}
