namespace Company
{
    public class WebDeveloper : Employee
    {
        public WebDeveloper(FullName personName, TaskType specialization, int countOfTasks, int timeToComplete) : base(
            personName, specialization, countOfTasks, timeToComplete)
        {
            PersonName = personName;
            Specialization = TaskType.WebApp;
            CountOfTasks = countOfTasks;
            TimeToComplete = timeToComplete;
        }

        public override Product DoTask(Task task)
        {
            if (CheckTime(task))
            {
                CountOfTasks++;
                return new ProductWebApp(task.Name, task.Type);
            }

            return null;
        }
    }
}