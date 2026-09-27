namespace RouteAss_OOP_1;
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
    }
}

