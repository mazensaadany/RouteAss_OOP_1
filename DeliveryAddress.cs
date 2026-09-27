namespace RouteAss_OOP_1;

public struct DeliveryAddress
{
    private string City;
    private string Street;
    private int BuildingNumber;

    public DeliveryAddress(string city,string street,int buildNum)
    {
        City = city;
        Street = street;
        BuildingNumber = buildNum;
    }

    public string GetfullAdress()
    {
        return $"City: {City}| Street: {Street}| Building: {BuildingNumber}";
    }

}
