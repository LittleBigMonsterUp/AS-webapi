using ASWebapi22.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace ASWebapi22.DAL
{
    public class AccountInitializer :
        DropCreateDatabaseIfModelChanges<AccountContext>
    {
        protected override void Seed(AccountContext context)
        {

            var adminUser = new List<AdminUser>
            {
                new AdminUser {ID=1,Password="123",Administorname="147789" },
                new AdminUser   {ID=2,Password="123",Administorname="147258"}
            };
            adminUser.ForEach(s => context.AdminUser.Add(s));
            context.SaveChanges();
            var relationships = new List<Relationship>
            {
                new Relationship {ID=1,Role="管理员",UserName="风" },
                new Relationship   {ID=2,Role="普通用户",UserName="雨"}
            };
            relationships.ForEach(s => context.Relationship.Add(s));
            context.SaveChanges();
            var users = new List<User>
            {
                new User {ID=1,UserNmae="风",Password="123" },
                new User   {ID=2,UserNmae="雨",Password="123"}
            };
            users.ForEach(s => context.User.Add(s));
            context.SaveChanges();
            var userRles = new List<UserRole>
            {
                new UserRole {ID=1,},
                new UserRole {ID=2,}
            };
            userRles.ForEach(s => context.UserRole.Add(s));
            context.SaveChanges();
        }
    }
}