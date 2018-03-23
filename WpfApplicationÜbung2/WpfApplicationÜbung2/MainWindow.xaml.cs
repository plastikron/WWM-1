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

namespace WpfApplicationÜbung2
{
    /// <summary>
    /// Interaktionslogik für MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        List<String> namen;
        public MainWindow()
        {
            InitializeComponent();
            namen = new List<string>();
            namen.Add("Katrin");
            namen.Add("Jonas");
            namen.Add("Simon");
            list_namen.ItemsSource = namen;
        }
    }
}
