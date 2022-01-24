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

namespace Harjoitus21
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        public MainWindow()
        {
            InitializeComponent();
        }
        private void btn_LisääTuotteet_Click(object sender, RoutedEventArgs e)
        {

            if ((bool)cb_Omena.IsChecked)
            {
                StackPanel;
            }

        }

        private void cb_Omena_Checked(object sender, RoutedEventArgs e)
        {
        }

        private void cb_Leipä_Checked(object sender, RoutedEventArgs e)
        {

        }

        private void cb_Karkkipussi_Checked(object sender, RoutedEventArgs e)
        {

        }

        private void cb_Energiajuoma_Checked(object sender, RoutedEventArgs e)
        {

        }

        private void cb_Vehnäjauhot_Checked(object sender, RoutedEventArgs e)
        {

        }

    }
}
