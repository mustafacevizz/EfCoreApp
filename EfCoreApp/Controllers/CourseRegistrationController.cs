using EfCoreApp.Data;
using EfCoreApp.Models;
using Microsoft.AspNetCore.Components.Forms;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics;

namespace EfCoreApp.Controllers
{
    public class CourseRegistrationController : Controller
    {
        private readonly DataContext _context;
        public CourseRegistrationController(DataContext context)
        {
            _context = context;
        }


        public async Task<IActionResult> Index()
        {
            var allRegisters=await _context
                .AllRegisters
                .Include(s=>s.Student)  //Upload all student information associated with course registrations
                .Include(c=>c.Course)   //Likewise, load all linked courses
                .ToListAsync();
            return View(allRegisters);
        }

        public async Task<IActionResult> Create()
        {
            ViewBag.Students=new SelectList(await _context.Students.ToListAsync(),"StudentId","StudentFullName");
            ViewBag.Courses=new SelectList(await _context.Courses.ToListAsync(),"CourseId","Title");

            return View();
        }


        [HttpPost]
        [AutoValidateAntiforgeryToken]

        public async Task<IActionResult> Create(RegisterCourse model)
        {
            model.RegisterTime = DateTime.Now;
            _context.AllRegisters.Add(model);
            await _context.SaveChangesAsync();
            return RedirectToAction("Index");
        }
        
       
    
    }

}

