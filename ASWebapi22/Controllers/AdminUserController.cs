using ASWebapi22.DAL;
using ASWebapi22.Models;
using ASWebapi22.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace ASWebapi22.Controllers
{
              [RoutePrefix("api/AdminUser")]
    public class AdminUserController : ApiController
    {

          
            private UnitOfWork unitOfWork = new UnitOfWork();
            [ActionName("AdminUserRegister")]
            [HttpPost]
            public Meassage AdminUserRepository(AdminUser user)
            {
                AdminUser adminUser = new AdminUser();
                var adminUser1 = unitOfWork.AdminUserRepository.Get();
               // var admin = adminUser1.FirstOrDefault();
                Meassage meassage = new Meassage();
                var a = (  from u in adminUser1
                           where u.Administorname == user.Administorname|| u.Password==user.Password
                           select u
                       ).Count();

                if (a > 0)
                {
                    meassage.statue = "error";
                    meassage.meassage = "登录失败";
    
                }
                else
                {

                  meassage.statue = "success";
                   meassage.meassage = "登录成功";

                }         

                return meassage;
            }



    }
}
