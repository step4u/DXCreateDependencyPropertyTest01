using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace DXCreateDependencyPropertyTest01
{
    /// <summary>
    /// Interaction logic for UserControl1.xaml
    /// </summary>
    public partial class UserControl1 : UserControl
    {
        public UserControl1()
        {
            InitializeComponent();
        }



        public string LbFrequency
        {
            get { return (string)GetValue(LbFrequencyProperty); }
            set { SetValue(LbFrequencyProperty, value); }
        }

        public static readonly DependencyProperty LbFrequencyProperty =
            DependencyProperty.Register("LbFrequency", typeof(string), typeof(UserControl1), new PropertyMetadata(string.Empty));



        public string Frequency
        {
            get { return (string)GetValue(FrequencyProperty); }
            set { SetValue(FrequencyProperty, value); }
        }

        // Using a DependencyProperty as the backing store for Frequency.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty FrequencyProperty =
            DependencyProperty.Register("Frequency", typeof(string), typeof(UserControl1), new PropertyMetadata(string.Empty));



        public string LbDg
        {
            get { return (string)GetValue(LbDgProperty); }
            set { SetValue(LbDgProperty, value); }
        }

        // Using a DependencyProperty as the backing store for MyProperty.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty LbDgProperty =
            DependencyProperty.Register("LbDg", typeof(string), typeof(UserControl1), new PropertyMetadata(string.Empty));



        public int DgSelectedIndex
        {
            get { return (int)GetValue(DgSelectedIndexProperty); }
            set { SetValue(DgSelectedIndexProperty, value); }
        }

        // Using a DependencyProperty as the backing store for SelectedIndex.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty DgSelectedIndexProperty =
            DependencyProperty.Register("DgSelectedIndex", typeof(int), typeof(UserControl1), new PropertyMetadata(0));



        public Dictionary<int, string> DgItemsSource
        {
            get { return (Dictionary<int, string>)GetValue(DgItemsSourceProperty); }
            set { SetValue(DgItemsSourceProperty, value); }
        }

        // Using a DependencyProperty as the backing store for DegreeItemsSource.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty DgItemsSourceProperty =
            DependencyProperty.Register("DgItemsSource", typeof(Dictionary<int, string>), typeof(UserControl1), new PropertyMetadata(null));


    }
}
