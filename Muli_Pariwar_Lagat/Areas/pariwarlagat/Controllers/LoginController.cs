using Muli_Pariwar_Lagat.Models;
using Muli_Pariwar_Lagat.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;

namespace Muli_Pariwar_Lagat.Areas.pariwarlagat.Controllers
{
    [AllowAnonymous]
    public class LoginController : Controller
    {
       
        // GET: Login
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Index(LoginViewModel lvm, string ReturnUrl)
        {
            if (ModelState.IsValid)
            {
                if (Membership.ValidateUser(lvm.UserName, lvm.Password))
                {
                    FormsAuthentication.SetAuthCookie(lvm.UserName ,true);

                    if (ReturnUrl != null)
                    {
                        return Redirect(ReturnUrl);
                    }
                    else if (ReturnUrl == null && lvm.UserName == "admin")
                    { return Redirect("~/pariwarlagat/Dashboard"); }
                    else
                    {
                        return Redirect("~/Home/Index");
                    }




                }

            }
            return View(lvm);
        }
        public ActionResult Logout()
        {
            FormsAuthentication.SignOut();
            return Redirect("~/pariwarlagat/Login");
        }
    }
}