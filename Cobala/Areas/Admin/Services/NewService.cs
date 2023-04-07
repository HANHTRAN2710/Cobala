using Cobala.Models;

namespace Cobala.Areas.Admin.Services
{
    public interface NewService
    {
        public List<Tintuc> findAll();
        public bool Create(Tintuc tintuc);
        public Tintuc findById(int id);
        //public bool Update(Tintuc tintuc);
    }
}
