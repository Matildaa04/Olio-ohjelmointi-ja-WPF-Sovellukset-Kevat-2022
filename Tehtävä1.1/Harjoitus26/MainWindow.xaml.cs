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

namespace Harjoitus26
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private bool isX = false;

        int[] filledGrid = new int[9];
        int alreadyFilled = 0;
        int[] magicSquare =    //Meinaa että kolmen rivin summa aina 15
        {
         8, 1, 6,
         3, 5, 7,
         4, 9, 2
        };

        public MainWindow()
        {
            InitializeComponent();
            GameOverGrid.Visibility = Visibility.Hidden; //Piilottaa gridin
        }

        private void CheckIfAnyoneWin()
        {
            for (int i = 0; i < 9; i++)
                for (int j = 0; j < 9; j++)
                    for (int k = 0; k < 9; k++)
                        if (i != j && i != k && j != k)
                            if (filledGrid[i] == (isX ? 2 : 1) && filledGrid[j] == (isX ? 2 : 1) && filledGrid[k] == (isX ? 2 : 1))
                                if (magicSquare[i] + magicSquare[j] + magicSquare[k] == 15)
                                    EndGame(isX ? 2 : 1);
        }

        private void EndGame(int state) //stage: 0 -> tasapeli, 1 -> O voitto, 2 -> X voitto
        {
            GameGrid.Visibility = Visibility.Hidden; //Piilottaa "Game" gridin
            GameOverGrid.Visibility = Visibility.Visible; //Näyttää "GameOver" gridin
            WhosWin.Text = (state == 0) ? "Tasapeli!" : ("Voittaja: " + ((state == 1) ? "O" : "X")); //Jos tulee tasapeli
        }

        private void B_Click(object sender, RoutedEventArgs e)
        {
            int buttonIndex = Convert.ToInt32(((Button)sender).Tag.ToString().Last().ToString());
            TextBlock textBlock = (TextBlock)FindName("T_" + buttonIndex.ToString());
            if (filledGrid[buttonIndex - 1] == 0) //jos ei ole jo valittu
            {
                filledGrid[buttonIndex - 1] = (isX) ? 2 : 1;
                textBlock.Text = (isX) ? "X" : "O";
                whosRound.Text = "Pelaajan vuoro: " + textBlock.Text;
                alreadyFilled++; //Jos kaikki 9 ruutua täynnä -> peli on ohi

                CheckIfAnyoneWin();
                if (alreadyFilled >= 9)
                    EndGame(0); //Draw

                isX = !isX;
            }
        }

        private void ExitGame(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }

        private void RestartGame(object sender, RoutedEventArgs e)
        {
            isX = false;
            filledGrid = new int[9]; //0 -> 1 -> O, 2 -> X
            alreadyFilled = 0;

            //Tyhjentää nappien textBlockit
            for (int i = 0; i < 9; i++)
            {
                ((TextBlock)FindName("T_" + (i + 1).ToString())).Text = "";
            }

            //Change Grids visibility
            GameGrid.Visibility = Visibility.Visible; //Näyttää "Game" gridin
            GameOverGrid.Visibility = Visibility.Hidden; //Piilottaa "GameOver" gridin
        }
    }
}
