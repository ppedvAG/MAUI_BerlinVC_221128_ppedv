using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//vgl. M009_Plattformspezifika\DeviceOrientationService.cs und Plattforms\Android\Services\DeviceOrientationService.de
namespace MAUI_BerlinVC_221128_ppedv.Plattformspezifika
{
    public partial class DeviceOrientationService
    {
        public partial DeviceOrientation GetOrientation()
        {
            return DeviceOrientation.Undefined;
        }
    }
}
