using System.Data.SqlTypes;

namespace ASPNETMVCProject.Models
{
    public enum Category
    {
        Laptops,
        Phones,
        GPU
    }
    public class Product
    {
        //USER_ID INT,
        //Product_Name VARCHAR(255),
        //Product_Description VARCHAR(255),
        //Category VARCHAR(255),
        //Amount INT,
        //Discount INT,
        //Price INT,
        //FOREIGN KEY(USER_ID) REFERENCES Users(USER_ID)
        public int PRODUCT_ID { get; set; }
        public string Product_Name { get; set; }
        public Category Category { get; set; }
        public double Price { get; set; }
        public double DiscountPercent { get; set; }
        public double PriceWithDiscount { get => Price -= Price * DiscountPercent / 100; }

        public Product(int productId, string name, Category category, double price, double discountPercent = 0)
        {
            PRODUCT_ID = productId;
            Product_Name = name;
            Category = category;
            Price = price;
            DiscountPercent = discountPercent;
        }
    }
}
