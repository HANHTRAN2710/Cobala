using Cobala.Models;

namespace Cobala.Areas.Admin.Services
{
    public class NewServiceImpl : NewService
    {
        private DatabaseContext db;
        public NewServiceImpl(DatabaseContext _dbContext)
        {
            db = _dbContext;
        }
        public bool Create(Tintuc tintuc)
        {
            db.Tintucs.Add(tintuc);
            return db.SaveChanges() > 0;
        }

        public List<Tintuc> findAll()
        {
            return db.Tintucs.ToList();

        }

        public Tintuc findById(int id)
        {
            return db.Tintucs.Find(id);

        }

        //public bool Update(Tintuc tintuc)
        //{
        //    throw new NotImplementedException();
        //}
    }
}
