using System;
using System.Collections.Generic;
using System.Data;
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
using praltik1.NewPraktik1DataSetTableAdapters;

namespace praltik1
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        заказыTableAdapter zakaz = new заказыTableAdapter();
        пользователиTableAdapter polz = new пользователиTableAdapter();
        public MainWindow()
        {
            
            InitializeComponent();
            Zakaz.ItemsSource = zakaz.GetData();
            ComboBox.ItemsSource = polz.GetData();
            ComboBox.DisplayMemberPath = "имя";

        }


        private void ComboBox_S(object sender, SelectionChangedEventArgs e)
        {
            object cell = (ComboBox.SelectedItem as DataRowView).Row[0];
            MessageBox.Show(cell.ToString());
        }
    }
}
