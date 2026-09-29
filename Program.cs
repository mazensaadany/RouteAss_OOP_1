namespace RouteAss_OOP_1;
using RouteAss_OOP_1;

internal class Program
{
    static void Main(string[] args)
    {
        #region [PART 1]
        #region answer 1
        //when its copied another independent version is being declard
        //and any modification doesn't affect the original struct
        #endregion

        #region answer 2
        //since class customer is ref type any modification
        //would affect the original class
        #endregion

        #region answer 3
        //public struct Shipment
        //{
        //public string Description; 
        //public double Weight; 
        //public decimal DeliveryFee;
        //}

        //the fields are public so anyone can reach it
        //no validation 
        //no properties
        #endregion

        #region answer 4
        //private fields achieves more security 

        //public properties better option so when we mod or 
        //change something we don't have to do it through the entire code
        #endregion
        #endregion
        //-----------------------------------------------//
        #region PART 2

        #region ans 1
        DeliveryAddress address = new DeliveryAddress("cairo", "9th", 17);
        DeliveryAddress address02 = address;

        address02 = new DeliveryAddress("giza", "foaad", 271);

        Console.WriteLine(address02.GetfullAdress());
        Console.WriteLine("-------------");
        Console.WriteLine(address.GetfullAdress());
        #endregion
        Console.WriteLine("________________________________________");
        #region ans 2
        //A
        DeliveryCenter deliveryCenter = new DeliveryCenter();
        //B

        for (int i = 0; i < 3; i++)
        {
            Shipment shipment = new Shipment();
            DeliveryAddress addr = new DeliveryAddress();

            Console.WriteLine($"enter shipment {i + 1} details:");

            Console.WriteLine("Tracking Code:");
            shipment.TrackingCode = Console.ReadLine();
            Console.Write($"description{i + 1}:");
            shipment.Description = Console.ReadLine();
            Console.Write($"weight{i + 1}:");
            shipment.Weight = Console.Read();
            Console.WriteLine(" ");
            Console.Write($"delivery fee{i + 1}:");
            shipment.DeliveryFee = Console.Read();
            Console.WriteLine(" ");

            Console.Write($"City{i + 1}:");
            addr.City = Console.ReadLine();
            Console.Write($"street{i + 1}:");
            addr.Street = Console.ReadLine();
            Console.Write($"Building{i + 1}:");
            addr.BuildingNumber = Console.Read();
            shipment.Destination = addr;

            deliveryCenter.AddShipment(shipment);

            Console.WriteLine("Shipment added successfully");
        }
        #endregion
        Console.WriteLine("________________________________________");
        #region ans3
        for (int i = 0; i < 3; i++)
        {
            Console.WriteLine($"tracking code{i + 1}:{deliveryCenter[i].TrackingCode}");
            Console.WriteLine($"description{i + 1}:{deliveryCenter[i].Description}");
            Console.WriteLine($"weight{i + 1}:{deliveryCenter[i].Weight}");
            Console.WriteLine($"fee{i + 1}:{deliveryCenter[i].DeliveryFee}");
            Console.WriteLine($"city{i + 1}:{deliveryCenter[i].Destination.City}");
            Console.WriteLine($"street{i + 1}:{deliveryCenter[i].Destination.Street}");
            Console.WriteLine($"building{i + 1}:{deliveryCenter[i].Destination.BuildingNumber}");
        }

        #endregion
        Console.WriteLine("________________________________________");
        #region ans 4
        Console.WriteLine("enter tracking code");
        string code = Console.ReadLine();

        Shipment shipment1 = deliveryCenter[code];
        if (shipment1.TrackingCode != null)
        {
            shipment1.PrintShipment();
        }
        else
        { Console.WriteLine("Shipment not found"); }
        #endregion
        Console.WriteLine("________________________________________");
        #region ans 5
        DeliveryAddress add01 = new DeliveryAddress("alex","1919",501);
        DeliveryAddress add02 = add01;

        add02.City = "noba";
        Console.WriteLine($"City 1 is:{add01.City}");
        Console.WriteLine($"City 1 is:{add02.City}");
        #endregion

        #endregion
    }
}

