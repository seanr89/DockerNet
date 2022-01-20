
using DocNetPostgre.Context;
using DocNetPostgre.Models;
using Microsoft.AspNetCore.Mvc;

namespace DocNetPostgre.Controller;

[Route("api/[controller]")]
[ApiController]
public class StudentsController : ControllerBase
{
    private readonly ApplicationContext _context;

    public StudentsController(ApplicationContext context)
    {
        _context = context;
    }

    [HttpGet]
    public IActionResult Get()
    {
        return Ok(_context.Students.ToList());
    }

    [HttpGet("{id}", Name = "GetById")]
    public IActionResult GetById(string id)
    {
        var student = _context.Find<Student>(Guid.Parse(id));

        return Ok(student);
    }

    [HttpPost]
    public IActionResult Post([FromBody] Student student)
    {
        _context.Add(student);

        _context.SaveChanges();

        return CreatedAtRoute(nameof(GetById), new { id = student.Id }, student);
    }
}