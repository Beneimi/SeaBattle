using Sea_Battle;
using System.Collections.Generic;
using System.Windows;
using Point = Sea_Battle.Point;

namespace SeaBattle
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {

            InitializeComponent();
            Board b = new Board(10);
            List<Point> newship = new List<Point>();
            newship.Add(new Point(2, 2));
            newship.Add(new Point(2, 3));
            newship.Add(new Point(2, 4));
            newship.Add(new Point(2, 5));
            b.PlaceShipOnBoard(newship);

            b.ShootTile(new Point(2, 4));
            b.ShootTile(new Point(2, 5));
            b.ShootTile(new Point(2, 2));
            b.ShootTile(new Point(2, 3));

            textBox.Text = b.GetTile(new Point(2, 4)).Ship.IsSunk().ToString();
            
        }

        private void exit_Click(object sender, RoutedEventArgs e)
        {
            System.Windows.Application.Current.Shutdown();
        }
    }
}
