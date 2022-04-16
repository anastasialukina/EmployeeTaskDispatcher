namespace Company
{
    public class ProductWebApp : Product
    {
        public ProductWebApp(string ProductName, TaskType ProductType)
        {
            productName = ProductName;
            productType = ProductType;
        }

        public override string GetTitle()
        {
            return "Web Application";
        }
    }
}