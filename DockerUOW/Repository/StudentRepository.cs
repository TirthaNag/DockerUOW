using DockerUOW.Data;
using DockerUOW.Entities;

namespace DockerUOW.Repository
{
    public interface IStudentRepository : IGenericRepository<StudentEntity>
    {

    }
    public class StudentRepository : GenericRepository<StudentEntity>, IStudentRepository
    {
        public StudentRepository(DockerDbContext dockerDbContext) : base(dockerDbContext)
        {

        }
    }
}
