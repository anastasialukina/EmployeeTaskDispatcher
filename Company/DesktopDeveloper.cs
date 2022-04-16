namespace Company
{
    public class DesktopDeveloper : Employee
    {
        public DesktopDeveloper(FullName personName, TaskType specialization, int countOfTasks, int timeToComplete) :
            base(personName, specialization, countOfTasks, timeToComplete)
        {
            PersonName = personName;
            Specialization = TaskType.DesktopApp;
            CountOfTasks = countOfTasks;
            TimeToComplete = timeToComplete;
        }

        public override Product DoTask(Task task)
        {
            if (CheckTime(task))
            {
                CountOfTasks++;
                return new ProductDesktopApp(task.Name, task.Type);
            }

            return null;
        }
    }
}