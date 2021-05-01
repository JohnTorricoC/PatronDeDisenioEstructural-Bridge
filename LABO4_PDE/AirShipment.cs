using System;
using System.Collections.Generic;
using System.Text;
using System.Xml;

namespace LABO4_PDE_BRIDGE
{
    public class AirShipment : ISend
    {

        public void package(string deliverPackage, string pickUpPackage)
        {

            Console.WriteLine("The package was shipped by air: \n{0}\n{1}\n", deliverPackage, pickUpPackage);

        }

    }
}
