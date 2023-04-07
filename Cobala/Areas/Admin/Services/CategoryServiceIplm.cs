using Cobala.Models;
using Cobala.Areas.Admin.Services;

namespace Cobala.Areas.Admin.Services
{
    public class CategoryServiceIplm : CategoryService
    {
        private DatabaseContext db;
        public CategoryServiceIplm(DatabaseContext _dbContext)
        {
            db = _dbContext;
        }

        public bool Create(Category category)
        {
            db.Categories.Add(category);
            return db.SaveChanges() > 0;
        }

        public List<Category> findAll()
        {
            return db.Categories.ToList();
        }

        public Category findById(int id)
        {
            return db.Categories.Find(id);
        }

        public bool Update(Category category)
        {
            try
            {
                db.Entry(category).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
                return db.SaveChanges() > 0;
            }
            catch
            {
                return false;
            }
        }
    }
}
