using System.Collections.Generic;

namespace Company
{
    public class DesktopDepartment : Department
    {
        public DesktopDepartment(List<Employee> _Employees)
        {
            taskType = TaskType.DesktopApp;
            Employees = _Employees;
        }
    }
}