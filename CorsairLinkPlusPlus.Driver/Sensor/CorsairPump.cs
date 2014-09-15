﻿using CorsairLinkPlusPlus.Driver.Node;

namespace CorsairLinkPlusPlus.Driver.Sensor
{
    public class CorsairPump : CorsairCooler
    {
        internal CorsairPump(CorsairLinkDevice device, int id)
            : base(device, id)
        {

        }

        public override string GetSensorType()
        {
            return "Pump";
        }
    }
}