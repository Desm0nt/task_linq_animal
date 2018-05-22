using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task_linq_animal
{
    class Snake : Animal
    {
        public Snake()
        {
            _animalName = "Snake";
            _legsCount = 0;
            _withTail = true;
        }
        public override void Action()
        {
            Console.WriteLine(AnimalName + " can do: Ssss");
        }
    }
}
