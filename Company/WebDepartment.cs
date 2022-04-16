using System.Collections.Generic;

namespace Company
{
    public class WebDepartment : Department
    {
        public WebDepartment(List<Employee> _Employees)
        {
            taskType = TaskType.WebApp;
            Employees = _Employees;
        }
    }
}