﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DMX.Entities.Enumerations;

namespace DMX.Entities
{
    public class LedScanner : DmxDevice
    {
        const int NUMBER_OF_CHANNELS = 11;

        public LedScanner(string name, int startAddress, DmxDeviceTypes deviceType)
            : base(name, startAddress, deviceType)
        {
            Channels = new byte[NUMBER_OF_CHANNELS];
        }

        private byte[] channels;
        public byte[] Channels { get; private set; }

        public void OpenDatasheet()
        {
            System.Diagnostics.Process.Start(@"Datasheet LED Scanner - ALO60.pdf");
        }
    }
}