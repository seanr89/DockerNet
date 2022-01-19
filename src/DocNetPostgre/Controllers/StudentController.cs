
using DocNetPostgre.Context;
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
}