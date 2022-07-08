using System.Collections.Generic;
using Test2.Dto;

namespace Test2.Model.Repositories {
    public class UsersRepository {
        List<Users> users;

        public UsersRepository() {
            users = new List<Users>() {
                new Users{Id = 1, Name = "ahmad", Password = "11", Country = new Country() { Id = 1, Name = "Lebanon"} },
                new Users{Id = 2, Name = "mahdi", Password = "1122"}
             };
        }

        public List<Users> List() {
            return users;
        }

        public void Add(UserCountry add, string country) {
            Users addUsers = new Users { Id = add.Id, Name = add.Name, Password = add.Password, Country = new Country() { Id = add.countryId, Name = country } };
            users.Add(addUsers);
        }
    }
}
