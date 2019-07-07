using System;
using System.Collections.Generic;
using System.Text;

namespace BlazorWOL.Shared
{
    public class Device
    {
        public Guid Id { get; set; } = Guid.NewGuid();

        public string Name { get; set; }

        public string MACAddress { get; set; }
    }
}
