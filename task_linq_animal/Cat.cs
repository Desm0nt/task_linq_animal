using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task_linq_animal
{
    class Cat : Animal
    {
        public Cat()
        {
            _animalName = "Cat";
            _legsCount = 4;
            _withTail = true;
        }
        public override void Action()
        {
            Console.WriteLine(AnimalName + " can do: Meow");
        }
    }
}
