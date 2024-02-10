using MyWeb.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repository.IRepository
{
    public interface ICategoryRepository : IRepository<MyWeb.Models.Category>
    {
        void Update(MyWeb.Models.Category obj);
    }
}
