
using Muli_Pariwar_Lagat.ViewModels;
using Muli_Pariwar_Lagat.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Muli_Pariwar_Lagat.Areas.pariwarlagat.Controllers
{
    public class RegisterController : Controller
    {
        private MyDbContext db = new MyDbContext();
        [AllowAnonymous]
        // GET: Register
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Index(RegisterViewModel rvm)
        {
            
                if (db.Users.Count(u => u.Username == rvm.UserName) == 0 && db.Users.Count(u => u.Email == rvm.Email) == 0)
                {
                    User user = new User()
                    {
                        Username = rvm.UserName,
                        Password = rvm.Password,
                       
                        Email = rvm.Email,
                        
                        
                       
                        Name = rvm.Name,
                       
                        Designation = rvm.Designation

                    };

                db.Users.Add(user);
                    db.SaveChanges();
                    db.UserRoles.Add(new UserRole()
                    {
                        UserId = user.Id,
                        RoleId = 1

                    });
                    db.SaveChanges();


                    return Redirect("~/Muli_Pariwar_Lagat/Dashboard");
                }
                else
            {
                ViewBag.Error = "Email ALready Exists";
            }
                return View(rvm);
            }
        }
  }