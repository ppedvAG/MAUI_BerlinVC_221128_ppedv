using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MAUI_BerlinVC_221128_ppedv.Plattformspezifika
{
    public partial class DeviceOrientationService
    {
        public partial DeviceOrientation GetOrientation();
    }

    public enum DeviceOrientation
    {
        Undefined,
        Landscape,
        Portrait
    }
}
