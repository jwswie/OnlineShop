namespace ASPNETMVCProject.Models
{
    public class Product
    {
        public string Name { get; set; }
        public int Price { get; set; }
        public int Discount { get; set; }
        public string Image { get; set; }
        public string AltImage { get; set; }
        public string Description1 { get; set; }
        public string Description2 { get; set; }
        public string Description3 { get; set; }
        public string Description4 { get; set; }

        public Product(string name, int price, string image, string altImage,
             int discount = 0, string description1 = "default", string description2 = "default", string description3 = "default", string description4 = "default")
        {
            this.Name = name;
            this.Price = price;
            this.Discount = discount;
            this.Image = image;
            this.AltImage = altImage;
            this.Description1 = description1;
            this.Description2 = description2;
            this.Description3 = description3;
            this.Description4 = description4;
        }
    }

}
