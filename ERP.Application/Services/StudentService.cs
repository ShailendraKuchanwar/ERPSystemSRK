using AutoMapper;
using ERP.Application.DTOs.Student;
using ERP.Domain.Entities;
using ERP.Domain.Interfaces;

namespace ERP.Application.Services;

public class StudentService : IStudentService
{
    private readonly IGenericRepository<Student> _repository;
    private readonly IMapper _mapper;

    public StudentService(IGenericRepository<Student> repository, IMapper mapper)
    {
        _repository = repository;
        _mapper = mapper;
    }

    public async Task<List<StudentResponseDTO>> GetAllStudents()
    {
        var students = await _repository.GetAllAsync();
        return _mapper.Map<List<StudentResponseDTO>>(students);
    }

    public async Task<string> CreateStudent(StudentCreateDTO dto)
    {
        try
        {
            var student = _mapper.Map<Student>(dto);
            student.CreatedDate = DateTime.Now;
            await _repository.AddAsync(student);
            return "Student Added Successfully";
        }
        catch (Exception ex)
        {
            throw new Exception("Error while saving student: " + ex.Message);
        }
    }
}