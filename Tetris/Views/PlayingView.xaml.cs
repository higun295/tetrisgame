using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;

namespace Tetris.Views
{
    public partial class PlayingView : UserControl
    {
        // 기본 맵 사이즈 10 * 20
        private const int WIDTH = 10;
        private const int HEIGHT = 20;

        public PlayingView()
        {
            InitializeComponent();
            MapInitialize();
        }

        private void MapInitialize()
        {
            for (int i = 0; i < WIDTH; i++)
            {
                for (int j = 0; j < HEIGHT; j++)
                {
                    Grid subGrid = new Grid();
                    Border border = new Border
                    {
                        BorderBrush = Brushes.LightGray,
                        BorderThickness = new Thickness(1),
                    };
                    subGrid.Children.Add(border);

                    MainGrid.Children.Add(subGrid);
                    Grid.SetColumn(subGrid, i);
                    Grid.SetRow(subGrid, j);
                }
            }
        }
    }
}