using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task_linq_animal
{
    class Cow : Animal
    {
        public Cow()
        {
            _animalName = "Cow";
            _legsCount = 4;
            _withTail = true;
        }
        public override void Action()
        {
            Console.WriteLine(AnimalName + " can do: Moo");
        }
    }
}
