using DataAccess.Repository.IRepository;
using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repository
{
    public class ProductRepository : Repository<Models.Product>, IProductRepository
    {
        private ApplicationDbContext _db;
        public ProductRepository(ApplicationDbContext db) : base(db)
        {
            _db = db;
        }

        public void Add(Models.Product obj)
        {
            throw new NotImplementedException();
        }

        public void Add(MyWeb.Models.Category obj)
        {
            throw new NotImplementedException();
        }

        public void Remove(Models.Product obj)
        {
            throw new NotImplementedException();
        }

        public void Remove(MyWeb.Models.Category obj)
        {
            throw new NotImplementedException();
        }

        //public void Update(Models.Product obj)
        //{
        //   //_db.Products.Update(obj);
        //}

        public void Update(Models.Product obj)
        {
            throw new NotImplementedException();
        }

        public void Update(MyWeb.Models.Category obj)
        {
            throw new NotImplementedException();
        }
    }
}
