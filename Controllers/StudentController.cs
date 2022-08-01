using EscolaOnline.Api.Data;
using EscolaOnline.Api.Models;
using EscolaOnline.Api.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace EscolaOnline.Api.Controllers
{
    public class StudentController : ControllerBase
    {
        [HttpGet("v1/student")]
        public IActionResult GetStudentList([FromServices] EscolaOnlineDataContext context)
        {
            var studentList = context.students.ToList();
            return Ok(new ResultViewModel<List<Student>>(studentList));
        }

        [HttpGet("v1/student/{id:Guid}")]
        public IActionResult GetStudentById([FromRoute] Guid id,[FromServices] EscolaOnlineDataContext context)
        {
            var student = context.students.FirstOrDefault(x => x.Id == id);

            if (student == null)
                return NotFound();

            return Ok(new ResultViewModel<Student>(student));
        }

        [HttpPost("v1/student")]
        public IActionResult PostNewStudent([FromBody] Student model, [FromServices] EscolaOnlineDataContext context)
        {
            context.students.Add(model);
            context.SaveChanges();

            return Ok(new ResultViewModel<Student>(model));
        }

        [HttpDelete("v1/student/{id:Guid}")]
        public IActionResult DeleteStudentById([FromRoute] Guid id, [FromServices] EscolaOnlineDataContext context)
        {
            var student = context.students.FirstOrDefault(x => x.Id == id);
            context.students.Remove(student);
            context.SaveChanges();

            return Ok(new ResultViewModel<Student>(student));
        }

        [HttpPut("v1/student/{id:Guid}")]
        public IActionResult UpdateStudentById([FromRoute] Guid id, [FromBody] StudentViewModel model, [FromServices] EscolaOnlineDataContext context)
        {
            var student = context.students.FirstOrDefault(x => x.Id == id);

            if (student == null)
                return NotFound();

            student.Name = model.Name;
            student.PasswordHash = model.PasswordHash;

            context.Update(student);
            context.SaveChanges();

            return Ok(new ResultViewModel<Student>(student));
        }
    }
}
