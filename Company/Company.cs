using System.Collections.Generic;
using System.Linq;

namespace Company
{
    public class Company
    {
        private string _companyName;

        private List<Department> Departments;
        //public Order Order;

        public Company(string companyName, List<Department> departments)
        {
            _companyName = companyName;
            Departments = departments;
            //Order = new Order();
        }

        public List<Task> GetTasks(Order order)
        {
            var tasks = new List<Task>();
            foreach (TaskType i in order.OrderTypes)
            {
                var task = (new Task
                {
                    Type = i,
                    Description = "This is task",
                    Name = "Task for order" + order.name,
                    TimeInHours = order.TimeInHours
                });
                tasks.Add(task);
            }

            return tasks;
        }

        public bool CompleteTheOrder(Order order, ref Product[] requestedProducts)
        {
            if (order == null)
                return false;
            var tasks = GetTasks(order);
            var products = new List<Product>();
            var flag = CheckOrder(order);
            if (!flag)
                return false;
            foreach (Task i in tasks)
            {
                var department = Departments.First(d => d.taskType == i.Type);
                var product = department.Do(i);
                var nameOfProduct = product.GetTitle();
                products.Add(product);
            }

            requestedProducts = products.ToArray();
            return true;
        }

        public bool CheckOrder(Order order)
        {
            var tasks = GetTasks(order);
            foreach (Task i in tasks)
            {
                var department = Departments.First(d => d.taskType == i.Type);
                var flag = department.CheckOpportunity(i);
                if (!flag)
                    return false;
            }

            return true;
        }
    }
}