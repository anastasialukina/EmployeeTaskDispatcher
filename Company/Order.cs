namespace Company
{
    public class Order
    {
        public string name;
        public TaskType[] OrderTypes;
        private bool status;
        protected int timeInHours;

        public Order()
        {
            this.name = null;
            OrderTypes = null;
            this.timeInHours = 0;
            status = false;
        }

        public Order(string name, TaskType[] orderTypes, int timeInHours)
        {
            this.name = name;
            OrderTypes = orderTypes;
            this.timeInHours = timeInHours;
            status = false;
        }

        public int TimeInHours
        {
            get => timeInHours;
            set => timeInHours = value;
        }

        public bool Status
        {
            get => status;
            set => status = value;
        }
    }
}