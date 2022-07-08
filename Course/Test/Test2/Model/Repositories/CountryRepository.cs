using System.Collections.Generic;

namespace Test2.Model.Repositories {
    public class CountryRepository {
        List<Country> country;

        public CountryRepository() {
            country = new List<Country>() {
                new Country{Id = 1, Name = "Lebanon"},
                new Country{Id = 2, Name = "Egypt"}
            };
        }

        public List<Country> List() {
            return country;
        }

        public void Add(Country add) {
            country.Add(add);
        }
    }
}