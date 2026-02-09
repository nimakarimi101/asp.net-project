namespace WebApplication5.Models
{
    public class Education
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string Badge { get; set; }
        public string Image { get; set; }
        public int Price { get; set; }

        public Education(string title, string description, string badge,string image, int price)
        {
            Title = title;
            Badge = badge;
            Description = description;
            Image = image;
            Price = price;
        }
        
    }
}