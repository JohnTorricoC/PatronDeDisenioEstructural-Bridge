using System;
using System.Collections.Generic;
using System.Text;

namespace LABO4_PDE_BRIDGE
{
    public class UserEvaluation : Shipment
    {
        public string UserComments { get; set; }

        public override void Send()
        {
            string fullBody = string.Format("{0}\nUser Comments: {1}", DeliverPackage, UserComments);
            ShipmentSender.package(PickUpPackage, fullBody);
        }
    }
}
