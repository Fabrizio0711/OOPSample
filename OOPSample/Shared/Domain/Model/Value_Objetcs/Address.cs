namespace OOPSample.Shared.Domain.Model.Value_Objetcs;

public class Address
{
    public Address(string street, string city, string state, string zipCode, string country)
    {
        Street = street;
        City = city;
        State = state;
        ZipCode = zipCode;
        Country = country;
    }

    public string Street { get; }
    public string City { get; }
    public string State { get; }
    public string ZipCode { get; }
    public string Country { get; }

    public string GetAdressAsString()
    {
        return $"{Street}, {City} ,{ZipCode},{Country}";
    }
}