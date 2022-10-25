namespace Module1.models;

public class User
{
    public User(long id, string name, UserRole role, ISet<Order> orders, ISet<Item> items, BankCredentials bankCredentials)
    {
        Id = id;
        Name = name;
        Role = role;
        Orders = orders;
        Items = items;
        BankCredentials = bankCredentials;
    }

    public long Id { get; set; }
    public string Name { get; set; }
    public UserRole Role { get; set; }
    public ISet<Order> Orders { get; set; }
    public ISet<Item> Items { get; set; }
    public BankCredentials BankCredentials { get; set; }
}