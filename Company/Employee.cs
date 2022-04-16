namespace Company
{
    public class FullName
    {
        public FullName(string surname, string name, string patronymic)
        {
            Surname = surname;
            Name = name;
            Patronymic = patronymic;
        }

        public string Surname { get; set; }
        public string Name { get; set; }
        public string Patronymic { get; set; }
    }

    public abstract class Employee
    {
        public int CountOfTasks;
        public FullName PersonName;
        public TaskType Specialization;
        public int TimeToComplete;

        protected Employee(FullName personName, TaskType specialization, int countOfTasks, int timeToComplete)
        {
            PersonName = personName;
            Specialization = specialization;
            CountOfTasks = countOfTasks;
            TimeToComplete = timeToComplete;
        }

        public int SetCountOfTasks
        {
            set => CountOfTasks = value;
        }

        public int GetCountOfOrders
        {
            get => CountOfTasks;
        }

        public abstract Product DoTask(Task task);

        public bool CheckTime(Task task)
        {
            return (TimeToComplete <= task.TimeInHours);
        }
    }
}