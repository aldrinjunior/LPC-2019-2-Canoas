using AppPeople.Models;
using Microsoft.AspNetCore.Mvc;

namespace AppPeople.Controllers
{
    public class PeopleController : Controller
    {
        PersonRepository _repository = 
        new PersonRepository();

        public IActionResult Index()
        {
            var people = _repository.GetAll();          

            return View(people);
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Person person)
        {
            _repository.Create(person);

            return RedirectToAction("index");
        }

       [HttpGet]
        public IActionResult Edit( int id)
        {
            var per = _repository.GetById(id);
            return View(per);
        }

        [HttpPost]
        public IActionResult Edit(Person personAlterado)
        {
            _repository.Update(personAlterado);

            return RedirectToAction("index");
        }


        public IActionResult Delete(int id)
        {
            _repository.Delete(id);
            return RedirectToAction("Index");
        }
    
    }
}
