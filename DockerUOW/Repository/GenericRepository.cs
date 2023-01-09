using DockerUOW.Data;
using Microsoft.EntityFrameworkCore;

namespace DockerUOW.Repository
{
    public interface IGenericRepository<T> where T : class
    {
        Task<IEnumerable<T>> GetAllAsync();
        Task<T> GetById(int Id);
        Task<bool> AddAsync(T entity);
        Task<bool> Update(T entity);
        Task<bool> Delete(T entity);
    }
    public class GenericRepository<T> : IGenericRepository<T> where T : class
    {
        //Protedted variables
        protected readonly DockerDbContext dbContext;
        protected readonly DbSet<T> dbSet;

        //Constructor
        public GenericRepository(DockerDbContext _dbContext)
        {
            dbContext = _dbContext;
            dbSet = dbContext.Set<T>();
        }

        public Task<bool> AddAsync(T entity)
        {
            throw new NotImplementedException();
        }

        public Task<bool> Delete(T entity)
        {
            throw new NotImplementedException();
        }

        public async virtual Task<IEnumerable<T>> GetAllAsync()
        {
            return await dbSet.ToListAsync();
        }

        public async virtual Task<T> GetById(int Id)
        {
            #pragma warning disable CS8603 // Possible null reference return.
            return await dbSet.FindAsync(Id);
            #pragma warning restore CS8603 // Possible null reference return.
        }

        public Task<bool> Update(T entity)
        {
            throw new NotImplementedException();
        }
    }
}
