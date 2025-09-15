namespace WebApplication1.Controllers;
using Microsoft.AspNetCore.Mvc;

public class StudentController : Controller
{

    private readonly AppDbContext _context;

    public StudentController(AppDbContext context)
    {
        _context = context;
    }

    public IActionResult Index()
    {
        var students = _context.Student.ToList(); // Fetch from DB
        return View(students);
    }
    // Show the create form
    [HttpGet]
    public IActionResult Create()
    {
        return View();
    }
    // Handle form submission
    [HttpPost]
    [ValidateAntiForgeryToken]
    public IActionResult Create(WebApplication1.Models.Student student)
    {
        if (ModelState.IsValid)
        {
            _context.Student.Add(student);
            _context.SaveChanges();
            return RedirectToAction(nameof(Index));
        }
        return View(student);
    }
}
