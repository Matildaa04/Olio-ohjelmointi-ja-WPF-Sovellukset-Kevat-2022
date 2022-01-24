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

namespace LaskinProjekti
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        float lopputulos = 20;
        float summa;
        float erotus;
        float kertolasku;
        float jakolasku;

        public MainWindow()
        {
            InitializeComponent();
        }

        private void btn_Summa_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                float num1 = Convert.ToSingle(txt_Text1.Text);
                float num2 = Convert.ToSingle(txt_Text2.Text);
                tb_Lopputulos.Text = (num1 + num2).ToString();
            }
            catch (Exception)
            {

                MessageBox.Show("Syötä vain numeroita");
            }

        }

        private void btn_Erotus_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                float num1 = Convert.ToSingle(txt_Text1.Text);
                float num2 = Convert.ToSingle(txt_Text2.Text);
                tb_Lopputulos.Text = (num1 - num2).ToString();
            }
            catch (Exception)
            {

                MessageBox.Show("Syötä vain numeroita");
            }
        }

        private void btn_Kertolasku_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                float num1 = Convert.ToSingle(txt_Text1.Text);
                float num2 = Convert.ToSingle(txt_Text2.Text);
                tb_Lopputulos.Text = (num1 * num2).ToString();
            }
            catch (Exception)
            {

                MessageBox.Show("Syötä vain numeroita");
            }
        }

        private void btn_Jakolasku_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                float num1 = Convert.ToSingle(txt_Text1.Text);
                float num2 = Convert.ToSingle(txt_Text2.Text);
                tb_Lopputulos.Text = (num1 / num2).ToString();
            }
            catch (Exception)
            {

                MessageBox.Show("Syötä vain numeroita");
            }
        }
    }
}
