namespace Company
{
    public class ProductMobileApp : Product
    {
        public ProductMobileApp(string ProductName, TaskType ProductType)
        {
            productName = ProductName;
            productType = ProductType;
        }

        public override string GetTitle()
        {
            return "Mobile Application";
        }
    }
}