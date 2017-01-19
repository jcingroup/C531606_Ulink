using System.Web.Mvc;
using DotWeb.Controller;
using ProcCore.Business.DB0;
using System.Collections.Generic;
using System.Linq;
using ProcCore.HandleResult;
using DotWeb.CommSetup;
using System;

namespace DotWeb.Controllers
{
    public class EventsController : WebUserController
    {
        public ActionResult Index()
        {
            return Redirect("~/Events/Events004");
        }
        public ActionResult Events004()
        {
            return View("Events004");
        }
        public ActionResult Events003()
        {
            return View("Events003");
        }
        public ActionResult Events002()
        {
            return View("Events002");
        }
        public ActionResult Events001()
        {
            return View("Events001");
        }

        public ActionResult p2()
        {
            return View("Events_list");
        }

        public ActionResult p3()
        {
            return View("EventsJoin");
        }
        [HttpPost]
        public string sendMail(MailContent md)
        {
            ResultInfo r = new ResultInfo();
            #region 驗證碼
            //ValidateResponse Validate = ValidateCaptcha(md.response);
            //if (!Validate.Success)
            //{
            //    r.result = false;
            //    r.message = Resources.Res.Log_Err_googleValideNotEquel;
            //    return defJSON(r);
            //}
            #endregion
            try
            {
                using (db0 = getDB0())
                {
                    if (md.email == null)
                    {
                        r.result = false;
                        r.message = Resources.Res.Log_Err_MailAddressBlank;
                        return defJSON(r);
                    }
                    #region 信件發送
                    string Body = getMailBody("EventEmail", md);//套用信件版面
                    bool mail;
                    string mailfrom = md.name + ":" + md.email;

                    mail = Mail_Send(mailfrom, //寄信人
                                    CommWebSetup.MailToList, //收信人
                                    CommWebSetup.MailTitle_JoinUs, //信件標題
                                    Body, //信件內容
                                    true); //是否為html格式
                    if (mail == false)
                    {
                        r.result = false;
                        r.message = Resources.Res.Log_Err_SendMailFail;
                        return defJSON(r);
                    }
                    #endregion
                }
                r.result = true;
                r.message = Resources.Res.Log_Success_SendMail;
            }
            catch (Exception ex)
            {
                r.result = false;
                r.message = ex.Message;
            }
            return defJSON(r);
        }
    }
    public class MailContent
    {
        public string name { get; set; }//姓名
        public string email { get; set; }//email
        public string tel { get; set; }//電話
        public List<int> join_type { get; set; }//加入我們
        public string content { get; set; }// 提問內容
        public string response { get; set; }//google 驗證碼
    }
}
