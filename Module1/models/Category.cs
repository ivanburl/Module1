namespace Module1.models;

public class Category
{
    public Category(long id, string categoryName, ISet<Item> items)
    {
        Id = id;
        CategoryName = categoryName;
        Items = items;
    }

    public long Id { get; set; }
    public string CategoryName { get; set; }
    public ISet<Item> Items { get; set; }
}