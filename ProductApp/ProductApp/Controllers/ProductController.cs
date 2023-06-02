using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc;
using ProductApp.Models;
using System.Runtime.Intrinsics.Arm;

namespace Mvc_Demo.Controllers
{
    public class ProductController : Controller
    {
        //public string Index()
        //{
        //    return "Index Action Method";
        //}
        //public string Details()
        //{
        //    return "Deatils Action Method";
        //}
        //public string Create()
        //{
        //    return "Create Action Method";
        //}
        //public string Edit()
        //{
        //    return "Edit Action method ";
        //}
        //public string Delete()
        //{
        //    return "Delete Action Method";
        //}

        public IActionResult Create(Prod pr)
        {
            //return View();
            return Ok(pr);
        }

        public IActionResult Details()
        {
            return View();
        }

        public IActionResult Delete()
        {
            return View();
        }

        public IActionResult Edit(Prod pr)
        {
            //return View();
            return Ok(pr);
        }

        public IActionResult Index()
        {
            return View();
        }
    }
}









