namespace WebApplication1.Controllers;
using Microsoft.AspNetCore.Mvc;

public class StudentController : Controller
{
    public IActionResult Index()
    {
        var students = new List<Models.Student>
        {
            new Models.Student { Name = "Alice", Age = 20, Address = "123 Main St", Class = "Math", GPA = 3.5f },
            new Models.Student { Name = "Bob", Age = 22, Address = "456 Oak St", Class = "Science", GPA = 3.7f },
            new Models.Student { Name = "Charlie", Age = 21, Address = "789 Pine St", Class = "History", GPA = 3.9f }
        };
        return View(students);
    }
}