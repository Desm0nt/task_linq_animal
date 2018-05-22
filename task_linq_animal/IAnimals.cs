namespace task_linq_animal
{
    interface IAnimals
    {
        string AnimalName { get; }
        int LegsCount { get; }
        bool WithTail { get; }
        void Action();
    }
}
