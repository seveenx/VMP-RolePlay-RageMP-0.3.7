using System;
using System.Collections.Generic;
using System.Text;
using GTANetworkAPI;

namespace GVMPc.Items
{
    class champange : Item
    {

        public champange()
        {
            Id = 89;
            Name = "Champanger";
            ImagePath = "champange.png";
            WeightInG = 700;
            MaxStackSize = 25;
        }

        public override bool getItemFunction(Client p)
        {
            return true;
        }
    }
}