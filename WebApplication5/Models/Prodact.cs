public class Prodact
{
    public string Title { get; set; }
    public string Description { get; set; }
    public string Price { get; set; }
    public string GradientClass { get; set; }
    public string IconClass { get; set; }

    public Prodact(string title, string description, string price, string gradientClass, string iconClass)
    {
        Title = title;
        Description = description;
        Price = price;
        GradientClass = gradientClass;
        IconClass = iconClass;
    }
}