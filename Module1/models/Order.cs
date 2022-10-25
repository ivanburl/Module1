namespace Module1.models;

public class Order
{
    public Order(long id, ISet<Item> items, User buyer, OrderStatus orderStatus, Location buyerLocation)
    {
        Id = id;
        Items = items;
        Buyer = buyer;
        OrderStatus = orderStatus;
        BuyerLocation = buyerLocation;
    }

    public long Id { get; set; }

    public ISet<Item> Items { get; set; }

    public User Buyer { get; set; }

    public OrderStatus OrderStatus { get; set; }

    public Location BuyerLocation { get; set; }
}