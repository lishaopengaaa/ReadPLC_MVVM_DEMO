using CommunityToolkit.Mvvm.ComponentModel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReadPLC
{
    internal class Viewmodel1 : ObservableObject
    {
        public ReadPLCHelper PlcHelper => ReadPLCHelper.Instance;
        private string _plcData;
        public Viewmodel1()
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
                    OnPropertyChanged(nameof(PlcHelper.Text));
                }
            }
        }
    }
}
