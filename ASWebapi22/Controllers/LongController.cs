using ASWebapi22.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using ASWebapi22.Models;

namespace ASWebapi22.Controllers
{
    public class LongController : ApiController
    {
        //public UnitOfWork unitOfWork = new UnitOfWork();
        [ActionName("GetAdminUser")]
        [HttpGet]
        //public string GetAdminUser(AdminUser adminUser)
        public string GetAdminUser()
        {

            //var user1 = unitOfWork.AdminUserRepository.Get();
            //var user2 = user1.FirstOrDefault();
            return string.Format("用户ID:{0},用户账号:{1},用户密码:{2}。", 1,"小风谷", 123);
        }
    }
}
