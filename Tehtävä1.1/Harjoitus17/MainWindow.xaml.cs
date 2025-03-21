﻿using System;
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

namespace Harjoitus17
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        float lämpötila = 20;
        bool keittiöValot = false;
        bool olohuoneenValot = false;
        bool oviLukossa = true;
        public MainWindow()
        {
            InitializeComponent();

            tb_Lämpötila.Text = "Talon sisälämpötila on " + lämpötila;
            tb_KeittiöTila.Text = keittiöValot.ToString();
            tb_OlohuoneTila.Text = olohuoneenValot.ToString();
            btn_Ovi.Content = oviLukossa.ToString();
        }

        private void btn_Olohuone_Click(object sender, RoutedEventArgs e)
        {
            olohuoneenValot = !olohuoneenValot;
            tb_OlohuoneTila.Text = olohuoneenValot.ToString();
        }

        private void btn_Keittiö_Click(object sender, RoutedEventArgs e)
        {
            keittiöValot = !keittiöValot;
            tb_KeittiöTila.Text = keittiöValot.ToString();
        }

        private void btn_Ovi_Click(object sender, RoutedEventArgs e)
        {
            oviLukossa = !oviLukossa;
            btn_Ovi.Content = oviLukossa.ToString();
        }

        private void txt_Termostaatti_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(txt_Termostaatti.Text, "[^0-9]"))
            {
                MessageBox.Show("Please enter only numbers.");
                txt_Termostaatti.Text = "";
            }
            else
            {
                if (txt_Termostaatti.Text == "")
                    return;

                lämpötila = int.Parse(txt_Termostaatti.Text);
                tb_Lämpötila.Text = "Talon sisälämpötila on " + lämpötila;
            }
        }
    }
}
