using System;

namespace LABO4_PDE_BRIDGE
{
    public class Program
    {
        static void Main(string[] args)
        {
            ISend airShipment = new AirShipment();
            ISend maritimeShipment = new MaritimeShipment();

            Shipment shipment = new SystemShipment();
            shipment.DeliverPackage = "Package successfully delivered.";
            shipment.PickUpPackage = "package satisfactorily collected.";

            shipment.ShipmentSender = airShipment;
            shipment.Send();

            shipment.ShipmentSender = maritimeShipment;
            shipment.Send();

            UserEvaluation userComment = new UserEvaluation();
            userComment.DeliverPackage = "Package delivered. ";
            userComment.PickUpPackage = "Package picked up. ";
            userComment.UserComments = "Product collected in very good condition, shipping 10/10";

            userComment.ShipmentSender = airShipment;
            userComment.Send();

            Console.ReadKey();
        }
    }
}
