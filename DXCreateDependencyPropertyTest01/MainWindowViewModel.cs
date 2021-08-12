using DevExpress.Mvvm;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DXCreateDependencyPropertyTest01
{
    public class MainWindowViewModel : ViewModelBase
    {
        public MainWindowViewModel()
        {
            Frequencies = new Dictionary<int, string>();

            Frequencies.Add(0, "0");
            Frequencies.Add(1, "180");
            Frequencies.Add(2, "360");

            lbFreq = "주파수";
            Freq = "20.000000";
            lbDegree = "각도";
            SelectedIndex = 1;
        }

        public string lbFreq
        {
            get { return GetValue<string>(); }
            set { SetValue(value); }
        }

        public string Freq
        {
            get { return GetValue<string>(); }
            set { SetValue(value); }
        }

        public string lbDegree
        {
            get { return GetValue<string>(); }
            set { SetValue(value); }
        }

        public int SelectedIndex
        {
            get { return GetValue<int>(); }
            set { SetValue(value); }
        }

        public Dictionary<int, string> Frequencies { get; set; }
    }
}
