using Models;
using MyWeb.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repository.IRepository
{
    public interface IProductRepository : IRepository<Models.Product>
    {
        void Add(MyWeb.Models.Category obj);
        //void Remove(Product obj);
        void Remove(MyWeb.Models.Category obj);
        //void Update(Product obj);
        void Update(MyWeb.Models.Category obj);
    }
}
