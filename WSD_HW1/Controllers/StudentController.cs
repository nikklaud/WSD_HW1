using Microsoft.AspNetCore.Mvc;
using WSD_HW1.Models;

namespace WSD_HW1.Controllers;

[ApiController]
[Route("api/[controller]")]
public class StudentController: ControllerBase
{
    private readonly List<Student> _students = new()
    {
        new Student { Id = 1, Name = "Abdurakhman", Age = 20 },
        new Student { Id = 2, Name = "Leha", Age = 21 }
    };

    [HttpGet]
    public ActionResult<List<Student>> GetStudents()
    {
        return Ok(_students);
    }

    [HttpGet("{id}")]
    public ActionResult<Student> GetStudent(int id)
    {
        return Ok(_students.Find(x => x.Id == id));
    }
    
    [HttpPost]
    public ActionResult<Student> AddStudent(Student student)

    {

        student.Id = _students.Count + 1;
        _students.Add(student);
        return Ok(student);

    }

}