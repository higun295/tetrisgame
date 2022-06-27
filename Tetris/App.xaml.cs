using System.Windows;
using Tetris.ViewModel;

namespace Tetris
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        protected override void OnStartup(StartupEventArgs e)
        {
            base.OnStartup(e);

            MainWindow window = new MainWindow();
            MainViewModel vm = new MainViewModel();
            window.DataContext = vm;
            window.Show();
        }
    }
}