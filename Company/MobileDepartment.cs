using System.Collections.Generic;

namespace Company
{
    public class MobileDepartment : Department
    {
        public MobileDepartment(List<Employee> _Employees)
        {
            taskType = TaskType.MobileApp;
            Employees = _Employees;
        }
    }
}