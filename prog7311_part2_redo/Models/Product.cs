namespace prog7311_part2_redo.Models
{
    public class Product
    {
        public int Id { get; set; }
        public string ProductName { get; set; }
        public string ProductDescription { get; set; }
        public string ProductDate { get; set; }
        public string ProductType { get; set; }
        public int FarmerId { get; set; }
        public Farmer Farmer { get; set; }

        public Product()
        {  
        }
    }
}
