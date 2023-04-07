using Cobala.Models;

namespace Cobala.Areas.Admin.Services
{
    public interface CategoryService
    {
        public List<Category> findAll();
        public bool Create(Category category);
        public Category findById(int id);
        public bool Update(Category category);

    }
}
