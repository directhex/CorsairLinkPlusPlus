﻿#region LICENSE
/**
 * CorsairLinkPlusPlus
 * Copyright (c) 2014, Mark Dietzer & Simon Schick, All rights reserved.
 *
 * CorsairLinkPlusPlus is free software; you can redistribute it and/or
 * modify it under the terms of the GNU Lesser General Public
 * License as published by the Free Software Foundation; either
 * version 3.0 of the License, or (at your option) any later version.
 *
 * CorsairLinkPlusPlus is distributed in the hope that it will be useful,
 * but WITHOUT ANY WARRANTY; without even the implied warranty of
 * MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the GNU
 * Lesser General Public License for more details.
 *
 * You should have received a copy of the GNU Lesser General Public
 * License along with CorsairLinkPlusPlus.
 */
 #endregion

using CorsairLinkPlusPlus.Common.Controller;
using CorsairLinkPlusPlus.Driver.CorsairLink.Sensor;
using CorsairLinkPlusPlus.Driver.CorsairLink.USB;
using System;

namespace CorsairLinkPlusPlus.Driver.CorsairLink.Controller
{
    public abstract class ControllerBase : IController
    {
        private string registryName = null;

        internal virtual void Apply(Sensor.BaseSensorDevice sensor)
        {

        }

        internal virtual void Refresh(Sensor.BaseSensorDevice sensor)
        {

        }

        public string Name
        {
            get
            {
                if (registryName == null)
                {
                    //CorsairLinkPlusPlus.Driver.CorsairLink.Controller. = 50
                    Type type = this.GetType();
                    registryName = type.Namespace.Substring(50) + ".CorsairLink." + type.Name;
                }
                return registryName;
            }
        }
    }
}
