using System.Web.Mvc;
using DotWeb.Controller;
using ProcCore.Business.DB0;
using System.Collections.Generic;
using System.Linq;

namespace DotWeb.Controllers
{
    public class TopicController : WebUserController
    {
        public ActionResult List()
        {
            return View("Topic_list");
        }
        public ActionResult Content001()
        {
            return View("Topic_content001");
        }
        public ActionResult Content002()
        {
            return View("Topic_content002");
        }
        public ActionResult Content003()
        {
            return View("Topic_content003");
        }
        public ActionResult Content004()
        {
            return View("Topic_content004");
        }
        public ActionResult Content005()
        {
            return View("Topic_content005");
        }
        public ActionResult Content006()
        {
            return View("Topic_content006");
        }
    }

}
