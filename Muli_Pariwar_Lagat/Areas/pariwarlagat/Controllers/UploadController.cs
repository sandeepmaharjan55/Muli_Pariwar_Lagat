using Muli_Pariwar_Lagat.Models;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Muli_Pariwar_Lagat.Areas.pariwarlagat.Controllers
{
    public class UploadController : AdminController
    {
        private MyDbContext db = new MyDbContext();
        // GET: pariwarlagat/Upload

        public ActionResult UploadFiles()
        {
            return View();
        }
        [HttpPost]
        public ActionResult UploadFiles(HttpPostedFileBase[] files,Pdf filepdf)
        {

            //Ensure model state is valid  
            if (ModelState.IsValid)
            {   //iterating through multiple file collection   
                foreach (HttpPostedFileBase file in files)
                {
                    //Checking file is available to save.  
                    if (file != null)
                    {
                        var InputFileName = Path.GetFileName(file.FileName);
                        var ServerSavePath = Path.Combine(Server.MapPath("~/Areas/pariwarlagat/UploadedFiles/") + InputFileName);
                        //Save file to server folder  
                        file.SaveAs(ServerSavePath);



                      
                            db.Pdfs.Add(new Pdf
                            {
                                status = false,
                                File = ServerSavePath
                                

                            });
                            db.SaveChanges();

                            //assigning file uploaded status to ViewBag for showing message to user.  
                            ViewBag.UploadStatus = files.Count().ToString() + " files uploaded successfully.";
                    }

                }
            }
            return View();
        }
    }
}