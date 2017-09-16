using crud_people.Models;
using Microsoft.AspNetCore.Mvc;

namespace crud_people.Controllers
{
    public class PersonController : Controller
    {
        PersonRepository _repository = new PersonRepository();

        public IActionResult Index()
        {
            var people = _repository.GetAll();
            return View(people);
        }

        public IActionResult Delete(int id)
        {
            _repository.Delete(id);
            return RedirectToAction("Index");
        }
       
    }
}