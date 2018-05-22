using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task_linq_animal
{
    class Bug : Animal, IWings
    {
        private readonly bool _withWings;
        public bool WithWings { get { return _withWings; } }
        public Bug()
        {
            _animalName = "Bug";
            _legsCount = 6;
            _withTail = false;
            _withWings = true;
        }
        public override void Action()
        {
            Console.WriteLine(AnimalName + " can do: Scr-scr");
            if (_withWings)
            {
                Console.WriteLine(AnimalName + " have wings and can fly");
            }
        }
    }
}
