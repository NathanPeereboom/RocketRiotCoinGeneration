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

namespace rocketRiotv2
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Random random = new Random();
        public MainWindow()
        {
            InitializeComponent();
            List<Coin> Coins = new List<Coin>();
            for (int i = 0; i < 4; i++)
            {
                Coins.Add(new Coin(i, canvas, random));
            }

            foreach (Coin coin in Coins)
            {
                coin.generate(random.Next(40 , 140), random.Next(100 , 500));
            }

            
        }
    }
}
