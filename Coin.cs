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
using System.Drawing;


namespace rocketRiotv2
{
    public class Coin
    {
        int quadrant;
        Random random;
        Canvas canvas = new Canvas();
        public Rectangle coin = new Rectangle();
        BitmapImage bitmapImage;
        ImageBrush coinFill;
        
        
        public Coin(int q, Canvas c, Random r)
        {
            quadrant = q;
            canvas = c;
            random = r;
            //quadrant is not yet used
        }
        public void generate(int setX, int setY)
        {
            //Image
            bitmapImage = new BitmapImage(new Uri("coin.png", UriKind.Relative));
            coinFill = new ImageBrush(bitmapImage);
            coin.Fill = coinFill;

            //Coin size
            coin.Height = 20;
            coin.Width = 20;

            //Set Position
            
            Canvas.SetLeft(coin, setX + quadrant * 200);
            Canvas.SetTop(coin, setY);

            //Add to canvas
            canvas.Children.Add(coin);
        }

        public void collected()
        {

        }

        public void remove()
        {
            canvas.Children.Remove(coin);
        }

        public Rectangle specs()
        {
            return coin;
        }
    }
}
