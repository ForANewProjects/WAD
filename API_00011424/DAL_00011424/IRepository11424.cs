namespace DAL_00011424
{
    public interface IRepository11424<T>
    {
        Task<T?> GetAsync(int id);
        Task<IEnumerable<T>> GetAllAsync();
        Task CreateAsync(T entity);
        Task EditAsync(int id, T entity);
        Task DeleteAsync(int id);
    }
}
