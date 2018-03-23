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


namespace WpfApplicationÜbung3
{
    /// <summary>
    /// Interaktionslogik für MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        List<Person> personen= null;
        public MainWindow()
        {
            InitializeComponent();

            Person p1 = new Person("Hans","Wurst",28,"Hund");
            Person p2 = new Person("Edgar","Lubber",32,"Kadse");

            personen = new List<Person>();
            personen.Add(p1);
            personen.Add(p2);

            combobox_name.ItemsSource = personen;

        }

        public void button_geburtstag_Click(object sender, RoutedEventArgs e)
        {
            Person p = (Person)combobox_name.SelectedItem;
            p.Geburtstag();
        }
    }
}
