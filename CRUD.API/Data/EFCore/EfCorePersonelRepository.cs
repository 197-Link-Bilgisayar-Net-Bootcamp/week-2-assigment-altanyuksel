using CRUD.API.Model;

namespace CRUD.API.Data.EFCore {
  public class EfCorePersonelRepository : EfCoreRepository<Personel, MyMDBContext> {
    public EfCorePersonelRepository(MyMDBContext context) : base(context) {
    }
  }
}
