using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Aula08CrudPeopleEF.Models;
using Aula08CrudPeopleEF.Models.Interfaces;
using Aula08CrudPeopleEF.Models.Entities;
using Aula12CrudPeopleEFComOneToMany.Models.Entities;

namespace Aula08CrudPeopleEF.Controllers
{
    public class PeopleController : Controller
    {
        private IPersonRepository pRepository;
        public PeopleController(IPersonRepository personRepository)
        {
            pRepository = personRepository;
        }
        public IActionResult Index()
        {
            var people = pRepository.GetAll();
            return View(people);
        }

        public IActionResult Create()
        {            
            return View();
        } 

        [HttpPost]
        public IActionResult Create(Person person)
        {        
            person.city = new City(1,"Canoas");
            pRepository.Create(person);    
            return RedirectToAction("Index");
        } 

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
