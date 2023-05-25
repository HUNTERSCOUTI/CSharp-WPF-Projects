using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CommunityToolkit.Mvvm.ComponentModel;
using Syncfusion.UI.Xaml.Charts;

namespace ArduinoPigsty
{
    public partial class VM : ObservableObject
    {
        [ObservableProperty] private List<Sty> _data;

        [ObservableProperty] private int _styID;
        [ObservableProperty] private int _temp;
        [ObservableProperty] private bool _led;
        [ObservableProperty] private int _doorAngle;

        public VM()
        {
            Data = new List<Sty>()
            {
                new Sty { StyIDProp = 1, TempProp = 20, LEDProp = true, DoorAngleProp = 90 },
                new Sty { StyIDProp = StyID, TempProp = Temp, LEDProp = Led, DoorAngleProp = DoorAngle }
            };
        }
    }
}
