namespace Company
{
    public abstract class Product
    {
        public string productName;
        public TaskType productType;

        public abstract string GetTitle();
    }
}