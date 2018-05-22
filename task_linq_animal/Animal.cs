using System;

namespace task_linq_animal
{
    abstract class Animal: IAnimals
    {
        protected string _animalName;
        protected int _legsCount;
        protected bool _withTail;
        public string AnimalName { get { return _animalName; } }
        public int LegsCount { get { return _legsCount; } }
        public bool WithTail { get { return _withTail; } }
        public abstract void Action();
        public virtual void Info()
        {
            Console.WriteLine("Animal: " + AnimalName);
            Console.WriteLine("Legs count: " + LegsCount);
            if (_withTail)
            {
                Console.WriteLine("Have Tail.");
            }
            Action();
            Console.WriteLine();
        }
    }
}
