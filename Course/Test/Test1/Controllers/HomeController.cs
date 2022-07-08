using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using Test.DTO;
using Test.Models;

namespace Test.Controllers {
    public class HomeController : Controller {

        static List<Login> Users = new List<Login>() {
                new Login{Id = 1, Name = "ahmad", Password = "1122", Country = new Country() { Id = 1, Name = "Lebanon"} },
                new Login{Id = 2, Name = "mahdi", Password = "112233"}
         };

        static List<Country> Countries = new List<Country>() {
                new Country{Id = 1, Name = "Lebanon"},
                new Country{Id = 2, Name = "Egypt"}
            };

        public IActionResult Index() {
            return View();
        }

        public IActionResult Display() {
            return View(Users);
        }

        public IActionResult Add() {
            LoginCountry loginCountry = new LoginCountry() {
                Countries = Countries
            };
            return View(loginCountry);
        }

        [HttpPost]
        public IActionResult Add(LoginCountry loginCountry) {
            string name = Countries[loginCountry.countryId - 1].Name;
            Login login = new Login() {
                Id = loginCountry.Id,
                Name = loginCountry.Name,
                Password = loginCountry.Password,
                Country = new Country() {
                    Id = loginCountry.countryId,
                    Name = name
                }
            };

            Users.Add(login);
            return RedirectToAction(nameof(Display));
        }

        public IActionResult Privacy() {
            return View();
        }
    }
}
