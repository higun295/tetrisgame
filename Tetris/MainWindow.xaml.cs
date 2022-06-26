using System;
using System.Collections.Generic;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using System.Windows.Threading;

namespace Tetris
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public const double SUBGRIDWIDTH = 30;
        public const double SUBGRIDHEIGHT = 30;
        public const double WIDTHCOUNT = 10;
        public const double HEIGHTCOUNT = 15;

        private DispatcherTimer _mainTimer;
        private Grid _block;
        private Border _blockBorder;
        private int _time;

        private List<Grid> _blockList;

        public MainWindow()
        {
            InitializeComponent();

            _blockList = new List<Grid>();

            GridInitialize();
            MakeBlock();
            TimerInitialize();
        }

        private void GridInitialize()
        {
            // Grid 나누기
            // 가로 10, 세로 20
            for (int i = 0; i < WIDTHCOUNT; i++)
            {
                ColumnDefinition column = new ColumnDefinition();
                column.Width = new GridLength(SUBGRIDWIDTH, GridUnitType.Pixel);
                MainGrid.ColumnDefinitions.Add(column);
            }
            for (int i = 0; i < HEIGHTCOUNT; i++)
            {
                RowDefinition row = new RowDefinition();
                row.Height = new GridLength(SUBGRIDHEIGHT, GridUnitType.Pixel);
                MainGrid.RowDefinitions.Add(row);
            }

            for (int i = 0; i < WIDTHCOUNT; i++)
            {
                for (int j = 0; j < HEIGHTCOUNT; j++)
                {
                    Grid subGrid = new Grid();
                    MainGrid.Children.Add(subGrid);
                    Grid.SetColumn(subGrid, i);
                    Grid.SetRow(subGrid, j);

                    Border border = new Border
                    {
                        BorderBrush = new SolidColorBrush(Colors.Black),
                        BorderThickness = new Thickness(1),
                    };

                    subGrid.Children.Add(border);
                }
            }

            // window 사이즈 변경하기
            if (window.Width != SUBGRIDWIDTH * WIDTHCOUNT)
                window.Width = SUBGRIDWIDTH * WIDTHCOUNT * 1.1;
            if (window.Height != SUBGRIDHEIGHT * HEIGHTCOUNT)
                window.Height = SUBGRIDHEIGHT * HEIGHTCOUNT * 1.1;
        }

        private void MakeBlock()
        {
            _block = new Grid();
            _blockBorder = new Border
            {
                BorderBrush = new SolidColorBrush(Colors.Red),
                BorderThickness = new Thickness(2)
            };

            _block.Children.Add(_blockBorder);
            _blockList.Add(_block);

            MainGrid.Children.Add(_block);
        }

        private void MoveBlock()
        {
            Grid.SetRow(_block, _time);
            Grid.SetColumn(_block, 1);
        }

        #region [ Helpers ]

        private void TimerInitialize()
        {
            _mainTimer = new DispatcherTimer();
            _mainTimer.Tick += _mainTimer_Tick;
            _mainTimer.Interval = TimeSpan.FromSeconds(1);
            _mainTimer.Start();
        }

        private void _mainTimer_Tick(object sender, EventArgs e)
        {
            _time++;
            MoveBlock();
        }

        #endregion
    }
}