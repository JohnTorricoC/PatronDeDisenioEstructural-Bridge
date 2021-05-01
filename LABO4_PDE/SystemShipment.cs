using System;
using System.Collections.Generic;
using System.Text;

namespace LABO4_PDE_BRIDGE
{
    public class SystemShipment : Shipment
    {
        public override void Send()
        {
            ShipmentSender.package(DeliverPackage, PickUpPackage);
        }
    }
}
