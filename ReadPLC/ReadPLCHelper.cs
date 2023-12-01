using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using CommunityToolkit.Mvvm.ComponentModel;

namespace ReadPLC
{
    public class ReadPLCHelper : ObservableObject
    {
        private static readonly ReadPLCHelper _instance = new ReadPLCHelper();
        private string _text = "Hello World";
        private int i = 0;

        public static ReadPLCHelper Instance => _instance;

        private ReadPLCHelper()
        {
            Task.Run(() => ReadPLC());
        }

        private void ReadPLC()
        {
/*            while (true)
            {
                Thread.Sleep(1000);
                Text = $"Hello World {i++}";
            }*/
        }

        public string Text
        {
            get => _text;
            set
            {
                if (_text != value)
                {
                    _text = value;
                    OnPropertyChanged(nameof(Text));
                    // 此处可以添加额外的逻辑来处理值的变化
                }
            }
        }
    }


}
