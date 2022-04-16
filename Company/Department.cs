using System.Collections.Generic;
using System.Linq;

namespace Company
{
    public abstract class Department
    {
        public List<Employee> Employees;
        public TaskType taskType;

        public bool CheckOpportunity(Task task)
        {
            return Employees.Any(e => e.Specialization == task.Type && e.TimeToComplete <= task.TimeInHours);
        }

        public Product Do(Task task)
        {
            if (CheckOpportunity(task))
            {
                var employee = Employees
                    .Where(e => e.Specialization == task.Type && e.TimeToComplete <= task.TimeInHours)
                    .OrderBy(e => e.CountOfTasks)
                    .First();
                return employee.DoTask(task);
            }

            return null;
        }
    }
}