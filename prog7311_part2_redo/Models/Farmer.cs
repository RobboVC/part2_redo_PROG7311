namespace prog7311_part2_redo.Models
{
    public class Farmer
    {
        public int FarmerId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string PhoneNumber { get; set; }
        public string EmailAddress { get; set; }
        public List<Product> Products { get; set; }

        public Farmer() { }

    }
}
