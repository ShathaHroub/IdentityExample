using Identitynext2.Data;
using Identitynext2.Models.ViewModel;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using NuGet.Protocol;
using static Identitynext2.Models.ViewModel.CertificateViewModel;

namespace Identitynext2.Controllers
{
    public class DemoController : Controller
    {

        private AppDbContext db;

        public DemoController(AppDbContext _db)
        {
            db = _db;
        }

        public IActionResult Certificates()
        {

            var approvedCer = db.Certificates.Where(x => x.Status == ApprovalStatus.Approved).ToList();
            return View(approvedCer);
        }

        [HttpGet]
        public IActionResult CreateCer()
        {
               return  View();     
        }

        [HttpPost]
        public IActionResult CreateCer(CertificateViewModel model)
        {
            if (ModelState.IsValid)
            {
                model.Status = ApprovalStatus.Pending;
                db.Certificates.Add(model);
                db.SaveChanges();
                return RedirectToAction("Certificates");
            }
            return View(model);
        }

        [Authorize(Roles ="Office")]
        public IActionResult PendingCer()
        {
            var pendingCer = db.Certificates.Where(x  => x.Status == ApprovalStatus.Pending).ToList();

       
            return View(pendingCer);
        }

    

     

        [HttpPost]
        [Authorize(Roles = "Office")]

        public IActionResult ApproveCer(int id)
        {
            var cer = db.Certificates.Find(id);
            if (cer != null)
            {
               cer.Status = ApprovalStatus.Approved;
                db.SaveChanges();
            }
            return RedirectToAction("Certificates", "Demo");


        }

        [Authorize(Roles = "Office")]
        public IActionResult RejectCer(int id) { 
            var cr = db.Certificates.Find(id);
            if (cr != null)
            {
               cr.Status = ApprovalStatus.Rejected;
                db.SaveChanges();
            }
            return RedirectToAction("Certificates" , "Demo");
        }

        public IActionResult RejectedCertificates() {

            var RejectedCer = db.Certificates.Where(x => x.Status == ApprovalStatus.Rejected).ToList();
            return View(RejectedCer);
        
        }

    }
}
