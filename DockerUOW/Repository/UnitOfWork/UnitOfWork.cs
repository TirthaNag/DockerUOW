using DockerUOW.Data;
using System.Runtime.CompilerServices;

namespace DockerUOW.Repository.UnitOfWork
{
    public interface IUnitOfWork
    {
        IStudentRepository StudentRepository { get; }
        Task CompleteAsync();
    }
    public class UnitOfWork : IUnitOfWork, IDisposable
    {
        private readonly DockerDbContext dockerDbContext;
        public IStudentRepository StudentRepository { get; private set; }

        public UnitOfWork(DockerDbContext _dockerDbContext)
        {
            dockerDbContext = _dockerDbContext;
            StudentRepository = new StudentRepository(dockerDbContext);
        }

        public async Task CompleteAsync()
        {
            await dockerDbContext.SaveChangesAsync();
        }

        public void Dispose() => dockerDbContext.Dispose();
    }
}
