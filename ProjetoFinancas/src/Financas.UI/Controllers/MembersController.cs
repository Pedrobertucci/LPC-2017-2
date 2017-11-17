using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Financas.UI.Models;
using Financas.Repository.Repositories;
using Financas.Domain;

namespace Financas.UI.Controllers
{
    public class MembersController : Controller
    {
        private IMemberRepository _repository; 
        private ICityRepository _repositoryCity;
        public MembersController(
            IMemberRepository repository,
            ICityRepository repositoryCity)
        {
            _repository = repository;
            _repositoryCity = repositoryCity;
        }
        public IActionResult Index()
        {
            return View(_repository.GetAll());
        }       


        public IActionResult Create()
        {
            ViewBag.City = _repositoryCity.GetAll();
            return View();
        }  

        [HttpPost]
        public IActionResult Create(Member member)
        {
            _repository.Create(member);
            return RedirectToAction("Index");
        }           
    }
}