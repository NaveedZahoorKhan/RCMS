using System;
using System.Data.Entity;
using RCMS.DAL.Interfaces;
using RCMS.Models;

namespace RCMS.DAL.Classes
{
    public class UnitOfWork : RcmsContext, IUnitOfWork
    {
        private readonly Repository<Category> _categoryRepository;
        private readonly Repository<User> _userRepository;
        public DbSet<Category> Categories { get; set; }
        public DbSet<Customers> Customers { get; set; }
        public DbSet<User> Users { get; set; }

        public UnitOfWork()
        {
            _categoryRepository = new Repository<Category>(Categories);
            _userRepository = new Repository<User>(Users);

        }

        public IRepository<Category> CategoryRepository { get { return _categoryRepository; } }
        public IRepository<User> UserRepository { get { return _userRepository; } }

        public void Commit()
        {
            this.SaveChanges();
        }

    }
}