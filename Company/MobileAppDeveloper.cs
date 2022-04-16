namespace Company
{
    public class MobileDeveloper : Employee
    {
        public MobileDeveloper(FullName personName, TaskType specialization, int countOfTasks, int timeToComplete) :
            base(personName, specialization, countOfTasks, timeToComplete)
        {
            PersonName = personName;
            Specialization = TaskType.MobileApp;
            CountOfTasks = countOfTasks;
            TimeToComplete = timeToComplete;
        }

        public override Product DoTask(Task task)
        {
            if (CheckTime(task))
            {
                CountOfTasks++;
                return new ProductMobileApp(task.Name, task.Type);
            }

            return null;
        }
    }
}