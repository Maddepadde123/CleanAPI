using Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Database
{
    public class MockDatabase
    {
        public List<Dog> allDogs
        {
            get { return allDogsFromDatabase; }
            set { allDogsFromDatabase = value; }
        }

        private static List<Dog> allDogsFromDatabase = new()
        {
            new Dog
            {
                animalId = Guid.NewGuid(), Name="PeppeLeDog"
            },
            new Dog
            {
                animalId = Guid.NewGuid(), Name="Monica"
            },
            new Dog
            {
                animalId = Guid.NewGuid(), Name="Emma"
            },
            new Dog
            {
                animalId = Guid.NewGuid(), Name="Greta"
            },
            new Dog
            {
                animalId = Guid.NewGuid(), Name="Sonja"
            },
        };
    }
}
