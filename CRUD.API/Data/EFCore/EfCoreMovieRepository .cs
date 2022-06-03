using CRUD.API.Model;

namespace CRUD.API.Data.EFCore {
  public class EfCoreMovieRepository : EfCoreRepository<Movie, MyMDBContext> {
    public EfCoreMovieRepository(MyMDBContext context) : base(context) {
    }
  }
}