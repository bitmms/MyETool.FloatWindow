using System.Windows;

namespace MyETool.FloatWindow
{
    public partial class App
    {
        private void App_OnStartup(object sender, StartupEventArgs e)
        {
            new MainWindow().Show();
            new FloatBall().Show();
        }
    }
}
