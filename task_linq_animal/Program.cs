using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task_linq_animal
{
    class Program
    {
        static void Main(string[] args)
        {
            Group<Animal> animalGroup = new Group<Animal>("Animals");
            animalGroup.Add(new Cat());
            animalGroup.Add(new Cow());
            animalGroup.Add(new Dog());
            animalGroup.Add(new Bug());
            animalGroup.Add(new Raven());
            animalGroup.Add(new Snake());

            //ShowInfo(mammalsGroup);
            //ShowInfo(flyingGroup);
            //ShowInfo(otherGroup);
            ShowLinqs(animalGroup);

            Console.Read();
        }

        //static void ShowInfo(Group<Animal> animalGroup)
        //{
        //    foreach (var animal in animalGroup.GetList())
        //    {
        //        Console.WriteLine(animalGroup.GroupName);
        //        animal.Info();
        //    }
        //}

        static void ShowLinqs(Group<Animal> aGroup)
        {
            var legCount = from d in aGroup.GetList()
                         where d.LegsCount == 4
                         select d;
            var withTail = from d in aGroup.GetList()
                           where d.WithTail == true
                           select d;
            var sortByName = from d in aGroup.GetList()
                           orderby d.AnimalName
                             select d;
            var getByStart = from d in aGroup.GetList()
                             where d.AnimalName.ToUpper().StartsWith("C")
                             select d;
            int totalcount = (from d in aGroup.GetList() select d).Count();

            Console.WriteLine("\nWith 4 legs:");
            foreach (var a in legCount)
            {
                Console.WriteLine(a.AnimalName);
            }
            Console.WriteLine("\nWith tail:");
            foreach (var a in withTail)
            {
                Console.WriteLine(a.AnimalName);
            }
            Console.WriteLine("\nSort by name:");
            foreach (var a in sortByName)
            {
                Console.WriteLine(a.AnimalName);
            }
            Console.WriteLine("\nAnimals, start with C:");
            foreach (var a in getByStart)
            {
                Console.WriteLine(a.AnimalName);
            }
            Console.WriteLine("\nAnimals count");
            Console.WriteLine(totalcount);
        }
    }
}
