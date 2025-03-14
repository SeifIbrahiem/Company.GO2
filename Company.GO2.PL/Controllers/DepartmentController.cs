using Company.GO2.BLL.Repositories;
using Company.GO2.DAL.Models;
using Company.GO2.PL.DTOS;
using Microsoft.AspNetCore.Mvc;

namespace Company.GO2.PL.Controllers
{
    //MVC CONTROLLER
    public class DepartmentController : Controller
    {
        private readonly DepartmentRepository _departmentRepositry;

        //ASK CLR CREATE OBJECT FROM DEPARTMENTREPOSITORY
        public DepartmentController(DepartmentRepository departmentRepository)
            {
            _departmentRepositry = departmentRepository;
            }

        [HttpGet] //GET : /Department/Index
        public IActionResult Index()
        {
           
           var departments = _departmentRepositry.Getall();

            return View(departments);
        }

        [HttpGet]
        public IActionResult Create() 
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(CreateDepartmentDto model)
        {
            if (ModelState.IsValid) //server side validation
            {
                var department = new Department()
                {
                   Code = model.Code,
                   Name = model.Name,
                   CreatedDate= model.CreateAt,
                };
                var count = _departmentRepositry.Add(department);
                if (count > 0) 
                { 
                  return RedirectToAction(nameof(Index));
                }
            }


            return View();
        }








    }
}
