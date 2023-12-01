using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CommunityToolkit.Mvvm.ComponentModel;

namespace ReadPLC
{
    internal class Viewmodel2 : ObservableObject
    {
        public ReadPLCHelper PlcHelper => ReadPLCHelper.Instance;
        private string _plcData;
        public Viewmodel2()
        {
           PlcHelper.PropertyChanged += (sender, e) =>
            {
                if (e.PropertyName == nameof(ReadPLCHelper.Text))
                {
                    OnPropertyChanged(nameof(PLCData));
                }
            };
        }
        public string PLCData
        {
            get => PlcHelper.Text;
            set
            {
                if (PlcHelper.Text != value)
                {
                    PlcHelper.Text = value;
                    OnPropertyChanged(nameof(PLCData));
                }
            }
        }
    }
}
