using DataAccess.Repository.IRepository;
using Models;

namespace DataAccess.Repository
{
    public class CategoryRepository : Repository<MyWeb.Models.Category>, ICategoryRepository
    {
        private ApplicationDbContext _db;
        public CategoryRepository(ApplicationDbContext db) : base(db)
        {
            _db = db;
        } 
        public void Update(MyWeb.Models.Category obj)
        {
           //_db.Categories.Update(obj);
        }
    }
}
