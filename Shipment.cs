namespace RouteAss_OOP_1;

public struct Shipment
{
    public Shipment(string track)
    {
        TrackingCode = track;
        Description = "unKnown";
        Weight = 1;
        DeliveryFee = 50;
        Destination= new DeliveryAddress();
    }

    public Shipment(string track, string desc, int w8, int fee, DeliveryAddress Dest)
    {
        TrackingCode = track;
        Description = desc;
        Weight = fee;
        DeliveryFee = fee;
        Destination= Dest;
    }

    private string trackingCode;
    private string description;
    private int weight;
    private int deliveryFee;

    public DeliveryAddress Destination { get; set; }

    public string TrackingCode
    {
        get
        {
            return trackingCode;
        }

        private set
        {
            if (value != null && value != "" && value != " ")
            {
                trackingCode = value;
            }
        }
    }

    public string Description
    {
        get
        {
            return description;
        }

        set 
        {
            if (value != null && value != "" && value != " ")
            {
                 description = value;
            }
        }
    }

    public int Weight
    {
        get 
        {
            return weight;
        }
        set 
        {
            if (value > 0)
            {
                weight = value;
            }
        }
    }

    public int DeliveryFee
    {
        get
        {
            return deliveryFee;
        }
        set 
        {
            if (value>0)
            {
                deliveryFee = value; 
            }
 
        }
    }

    public int EstimatedCost
    {
        get { return DeliveryFee+(Weight*5); } 
    }

    public int UpdateDeliveryFee(int newFee)
    {
        if (newFee > 0)
        {
            DeliveryFee = newFee;
        }

        return DeliveryFee;
    }

    public void PrintShipment()
    {
        Console.WriteLine($"Destination is :{Destination}");
        Console.WriteLine($"Tracking code : {TrackingCode}");
        Console.WriteLine($"Description : {Description}");
        Console.WriteLine($"Weight : {Weight}");
        Console.WriteLine($"Delivery Fee : {DeliveryFee}");
        Console.WriteLine($"Estimated Cost : {EstimatedCost}");
    }
}

