using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using ASWebapi22.Models;
using ASWebapi22.DAL;
namespace ASWebapi22.Controllers
{
    public class RelationshipController : ApiController
    {
        public UnitOfWork unitOfWork = new UnitOfWork();
        [ActionName("GetRelationship")]
        [HttpGet]
        public string GetRelationship(Relationship relationship)
        {
           
            var user1 = unitOfWork.RelationshipRepository.Get();
            var user2 = user1.FirstOrDefault();
            return string.Format("用户ID:{0},用户账号:{1},用户角色:{2}。",user2.ID,user2.UserName,user2.Role);
        }
    }
}