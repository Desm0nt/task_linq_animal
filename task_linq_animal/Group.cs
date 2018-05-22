using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task_linq_animal
{
    class Group<T>
        where T : class
    {
        //public enum Types
        //{
        //    Mammals = 1,
        //    Flying,
        //    Other
        //}
        //public Types GroupName { get; set; }
        //public T Animal { get; set; }

        //public Group2(T value, int type)
        //{            
        //    Animal = value;
        //    GroupName = (Types)type;
        //}
        private List<T> _animalsList;
        private string _groupName;
        public string GroupName { get { return _groupName; } }
        public Group(string animalsType)
        {
            _animalsList = new List<T>();
            _groupName = animalsType;
        }
        public void Add(T item)
        {
            _animalsList.Add(item);
        }
        public void Remove(T item)
        {
            _animalsList.Remove(item);
        }
        public void Remove(int id)
        {
            if (id > _animalsList.Count - 1)
                throw new IndexOutOfRangeException();
            else
            {
                _animalsList.RemoveAt(id);
            }
        }
        public T Get(int id)
        {
            if (id > _animalsList.Count - 1)
                throw new IndexOutOfRangeException();
            else
            {
                return _animalsList[id];
            }
        }
        public List<T> GetList()
        {
            return _animalsList;
        }
    }
}
