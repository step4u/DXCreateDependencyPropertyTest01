using DevExpress.Mvvm;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DXCreateDependencyPropertyTest01
{
    public class Frequency : BindableBase
    {
        public Frequency()
        {
            Frequencies = new Dictionary<int, string>();

            Frequencies.Add(0, "0");
            Frequencies.Add(0, "180");
            Frequencies.Add(0, "360");
        }

        public string lbFrequency
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
