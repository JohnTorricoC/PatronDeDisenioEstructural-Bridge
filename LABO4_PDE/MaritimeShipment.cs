using System;
using System.Collections.Generic;
using System.Text;

namespace LABO4_PDE_BRIDGE
{
    public class MaritimeShipment : ISend
    {

        public void package(string deliverPackage, string pickUpPackage)
        {

            Console.WriteLine("The package was shipped by sea: \n{0}\n{1}\n", deliverPackage, pickUpPackage);

        }

    }
}
