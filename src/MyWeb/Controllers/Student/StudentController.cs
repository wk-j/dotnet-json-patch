using Microsoft.AspNetCore.JsonPatch;
using Microsoft.AspNetCore.Mvc;

namespace MyWeb.Controllers.Student;

public class Student {
    public int Id { get; set; }
    public string Name { get; set; }
    public string Email { get; set; }
    public DateTime CreatedAt { get; set; }
}

[ApiController]
[Route("api/student")]
public class StudentController : ControllerBase {

    [HttpPatch("update")]
    public ActionResult<Student> Update([FromBody] JsonPatchDocument<Student> patch) {
        var student = new Student {
            Id = 1,
            Name = "wk",
            Email = "wk@gmail.com",
            CreatedAt = DateTime.Now
        };

        patch.ApplyTo(student);

        return student;
    }
}