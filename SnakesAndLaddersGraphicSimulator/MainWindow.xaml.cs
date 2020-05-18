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

namespace SnakesAndLaddersGraphicSimulator
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        

        public MainWindow()
        {
            InitializeComponent();

            SolidColorBrush whiteBrush = new SolidColorBrush(Color.FromRgb(240,230,220));
            SolidColorBrush blackBrush = new SolidColorBrush(Color.FromRgb(10, 20, 30));

            for (int y = 0; y < 10; y++)
            {
                for (int x = 0; x < 10; x++)
                {
                    int locationNumber = GetLocationNumber(x,y);

                    Rectangle rect = new Rectangle();
                    rect.Width = 9;
                    rect.Height = 9;
                    rect.Fill = GetLocationNumber(x,y) % 2 == 0 ? whiteBrush: blackBrush;
                    Canvas.SetTop(rect, 10 * y);
                    Canvas.SetLeft(rect, 10 * x);

                    GameBoard.Children.Add(rect);
                }
            }

            
        }

        private int GetLocationNumber(int x, int y)
        {
            return y * 10 + x;
        }

    }
}
