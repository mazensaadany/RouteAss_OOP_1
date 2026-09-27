namespace RouteAss_OOP_1;

public struct Shipment
{
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
}

