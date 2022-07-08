using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using Test2.Dto;
using Test2.Model;
using Test2.Model.Repositories;

namespace Test2.Controllers {
    public class HomeController : Controller {

        private readonly UsersRepository usersRepository;
        private readonly CountryRepository countryRepository;

        public HomeController(UsersRepository usersRepository, CountryRepository countryRepository) {
            this.usersRepository = usersRepository;
            this.countryRepository = countryRepository;
        }

        public IActionResult Index() {
            return View();
        }

        public ActionResult GetAllUsers() {
            List<Users> users = usersRepository.List();
            return View(users);
        }

        public ActionResult AddUsers() {
            UserCountry userCountry = new UserCountry() {
                Countries = countryRepository.List()
            };
            return View(userCountry);
        }

        [HttpPost]
        public ActionResult AddUsers(UserCountry userCountry) {
            List<Country> countries = countryRepository.List();
            usersRepository.Add(userCountry, countries[userCountry.countryId-1].Name);
            return RedirectToAction(nameof(GetAllUsers));
        }

        public ActionResult GetAllCountries() {
            List<Country> countries = countryRepository.List();
            return View(countries);
        }

        public ActionResult AddCountries() {
            return View();
        }

        [HttpPost]
        public ActionResult AddCountries(Country country) {
            countryRepository.Add(country);
            return RedirectToAction(nameof(GetAllCountries));
        }

        public IActionResult Privacy() {
            return View();
        }
    }
}
