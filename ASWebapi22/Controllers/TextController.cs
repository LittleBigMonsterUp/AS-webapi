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
    public class TextController : ApiController
    {
        [RoutePrefix("api/GetUsers")]
        public class TestController : ApiController
        {
            private UnitOfWork unitOfWork = new UnitOfWork();

            /// <summary>
            /// getUser
            /// </summary>
            [Route("GetUsersInfo")]
            public List<AdminUser> GetUsersInfo()
            {
                var user = unitOfWork.AdminUserRepository.Get();
                // var users = user.Where(s => s.Phone != null).ToList();
                var usera = (from u in user
                             select u).ToList();
                return usera;
            }
        }
    }
}
