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

namespace wpf_flags
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

        private void FlagButton_Click(object sender, RoutedEventArgs e)
        {
            //om knappen är stor, gör den liten
            if(FlagButton.Content.ToString() == "big")
            {
                FlagButton.Content = "small";
                FlagButton.Height = 30;
                FlagButton.Width = 50;
                FlagButton.FontSize = 15;
            //om knappen är liten, gör den stor
            } else
            {
                FlagButton.Content = "big";
                FlagButton.Height = 60;
                FlagButton.Width = 100;
                FlagButton.FontSize = 30;
            }

            //skapa en ny knapp med alla egenskaper som den FlagButton har
            var newButton = new Button();
            newButton.Content = FlagButton.Content.ToString();
            newButton.Height = FlagButton.Height;
            newButton.Width = FlagButton.Width;
            newButton.FontSize = FlagButton.FontSize;

            //placera den nya knappen på någon random plats på gridden
            Grid.SetColumn(newButton, getRandomNumber());
            Grid.SetRow(newButton, getRandomNumber());
            MainGrid.Children.Add(newButton);

        }

        //få ett random tal
        public int getRandomNumber()
        {
            Random r = new Random();
            int number = r.Next(0, 3);
            return number;
        }

    }
}
