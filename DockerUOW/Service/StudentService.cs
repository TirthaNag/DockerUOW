using AutoMapper;
using DockerUOW.Dto;
using DockerUOW.Repository.UnitOfWork;

namespace DockerUOW.Service
{
    public interface IStudentService
    {
        public Task<IEnumerable<StudentDto>> GetAllStudents();
    }
    public class StudentService : IStudentService
    {
        private readonly IUnitOfWork unitOfWork;
        private readonly IMapper mapper;

        public StudentService(IUnitOfWork _unitofWork, IMapper _mapper)
        {
            unitOfWork = _unitofWork;
            mapper = _mapper;
        }

        public async Task<IEnumerable<StudentDto>> GetAllStudents()
        {
            return mapper.Map<IEnumerable<StudentDto>>(await unitOfWork.StudentRepository.GetAllAsync());
        }

    }
}
