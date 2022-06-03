using CRUD.API.Model;
using Microsoft.EntityFrameworkCore;

namespace CRUD.API.Data {
  public class MyMDBContext : DbContext {
    public MyMDBContext(DbContextOptions<MyMDBContext> options) : base(options) {

    }
    public DbSet<Movie> Movie {get;set;}
    public DbSet<Personel> Personel {get;set; }
  }
}
