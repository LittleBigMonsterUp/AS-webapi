using ASWebapi22.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ASWebapi22.Controllers
{
    public class HomeController : Controller
    {
        private AccountContext db = new AccountContext();
        private UnitOfWork unitOfWork = new UnitOfWork();
        public ActionResult Index()
        {
            ViewBag.Title = "风过无痕";        
            var adminuser = unitOfWork.AdminUserRepository.Get();
            var relationship = unitOfWork.RelationshipRepository.Get();
            var user = unitOfWork.UserRepository.Get();
            var userrole = unitOfWork.UserRoleRepository.Get();
            return View();
        }
    }
}
