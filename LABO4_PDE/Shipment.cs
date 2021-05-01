using System;
using System.Collections.Generic;
using System.Text;

namespace LABO4_PDE_BRIDGE
{

     public abstract class Shipment
     {
        public ISend ShipmentSender { get; set; } //MessageSender
        public string PickUpPackage { get; set; } //Subject
        public string DeliverPackage { get; set; } //Body
        public abstract void Send();       
     }
   

}
