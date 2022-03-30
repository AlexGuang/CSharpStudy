using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IEnumerableAndIenumerator
{
    internal class DogShelter: IEnumerable<Dog>
    {
        List<Dog> shelters;





        public DogShelter()
        {
            shelters = new List<Dog>()
            {
                new Dog("Jack", true),
                new Dog("DuiZhang", true),
                new Dog("Andi", false),
                new Dog("Damao", false),
                new Dog("Yanjing", true),
                new Dog("Wollebi", false)
            };
        }

        public IEnumerator<Dog> GetEnumerator()
        {
            return shelters.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            throw new NotImplementedException();
        }
    }
}
