using AutoMapper;
using ERP.Application.DTOs.Student;
using ERP.Domain.Interfaces;
using Microsoft.AspNetCore.Mvc;

[ApiController]
[Route("api/[controller]")]
public class StudentController : ControllerBase
{
    private readonly IStudentService _studentService;
    private readonly IMapper _mapper;

    public StudentController(IStudentService studentService, IMapper mapper)
    {
        _studentService = studentService;
        _mapper = mapper;
    }

    [HttpGet]
    public async Task<IActionResult> Get()
    {
        var students = await _studentService.GetAllStudents();
        return Ok(students);
    }

    [HttpPost]
    public async Task<IActionResult> Create(StudentCreateDTO dto)
    {
        try
        {
            var result = await _studentService.CreateStudent(dto);
            return Ok(new { message = result });
        }
        catch (Exception ex)
        {
            return BadRequest(new { error = ex.Message });
        }
    }
}