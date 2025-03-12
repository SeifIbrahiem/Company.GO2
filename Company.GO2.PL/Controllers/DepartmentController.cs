using Company.GO2.BLL.Repositories;
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
    }
}
