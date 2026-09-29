namespace RouteAss_OOP_1;
public struct DeliveryCenter
{
    private Shipment[] shipments;

    public DeliveryCenter()
    {
        shipments = new Shipment[10];
    }

    public Shipment this[int position]
    {
        get
        {
            if (position > 0 && position <10) 
            { 
                return shipments[position];
            }
            return default;
        }

        set
        {
            if (position > 0 && position < 10)
            {
                shipments[position] = value;
            }
        }
    }

    public Shipment this[string tracingcode] 
    {
        get
        {
            for (int i = 0; i < shipments.Length; i++)
            {
                if (shipments[i].TrackingCode == tracingcode)
                {
                    return shipments[i];
                }
            }
            return default;
        }
    }

    public bool AddShipment(Shipment newShipment)
    {
        for (int i = 0; i < 10; i++) 
        {
            if (shipments[i].TrackingCode == null)
            {
                shipments[i] = newShipment;
                return true;
            }
        }
        return false;
    }
}