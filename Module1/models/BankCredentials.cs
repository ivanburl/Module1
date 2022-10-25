namespace Module1.models;

public class BankCredentials
{
    public long Id;
    public string Credentials;

    public BankCredentials(long id, string credentials)
    {
        Id = id;
        Credentials = credentials;
    }
}