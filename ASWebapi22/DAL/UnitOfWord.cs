using ASWebapi22.Models;
using ASWebapi22.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ASWebapi22.DAL
{
    public class UnitOfWork : IDisposable
    {
        private AccountContext context = new AccountContext();


        private GenericRepository<AdminUser> adminUserRepository;
        private GenericRepository<Relationship> relationshipRepository;
        private GenericRepository<User> userRepository;
        private GenericRepository<UserRole> userRoleRepository;


        public GenericRepository<AdminUser> AdminUserRepository
        {
            get
            {
                if (this.adminUserRepository == null)
                {
                    this.adminUserRepository = new GenericRepository<AdminUser>(context);
                }
                return adminUserRepository;
            }
        }
        public GenericRepository<Relationship> RelationshipRepository
        {
            get
            {
                if (this.relationshipRepository == null)
                {
                    this.relationshipRepository = new GenericRepository<Relationship>(context);
                }
                return relationshipRepository;
            }
        }
        public GenericRepository<User> UserRepository
        {
            get
            {
                if (this.userRepository == null)
                {
                    this.userRepository = new GenericRepository<User>(context);
                }
                return userRepository;
            }
        }
        public GenericRepository<UserRole> UserRoleRepository
        {
            get
            {
                if (this.userRoleRepository == null)
                {
                    this.userRoleRepository = new GenericRepository<UserRole>(context);
                }
                return userRoleRepository;
            }
        }

        public object SysUserRepository { get; internal set; }
        public object UserRleRepository { get; internal set; }
        #region Save & Dispose
        public void Save()
        {
            context.SaveChanges();
        }

        private bool disposed = false;

        protected virtual void Dispose(bool disposing)
        {
            if (!this.disposed)
            {
                if (disposing)
                {
                    context.Dispose();
                }
            }
            this.disposed = true;
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
        #endregion
    }

}