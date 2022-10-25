namespace Module1.models;

public class Item
{
    public long Id { get; set; }

    public string Name { get; set; }

    public long Price { get; set; }

    public long Quantity { get; set; }

    public User Owner { get; set; }
}