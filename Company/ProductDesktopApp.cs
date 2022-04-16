namespace Company
{
    public class ProductDesktopApp : Product
    {
        public ProductDesktopApp(string ProductName, TaskType ProductType)
        {
            productName = ProductName;
            productType = ProductType;
        }

        public override string GetTitle()
        {
            return "Desktop Application";
        }
    }
}