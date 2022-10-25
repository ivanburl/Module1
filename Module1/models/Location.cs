namespace Module1.models;

public class Location
{
    public Location(long id, string address)
    {
        Id = id;
        Address = address;
    }

    public long Id { get; set; }
    public string Address { get; set; }
}