namespace CRUD.API.Data {
  public interface IRepository<T> where T : class, IEntity {
    Task<List<T>> GetAll();
    Task<T> Get(int i);
    Task<T> Add(T entity);
    Task<T> Update(T entity);
    Task<T> Delete(int id);
  }
}
