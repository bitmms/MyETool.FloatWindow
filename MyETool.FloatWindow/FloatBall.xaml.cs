using System.Windows;
using System.Windows.Input;

namespace MyETool.FloatWindow
{
    public partial class FloatBall
    {
        public FloatBall()
        {
            InitializeComponent();
        }

        private void FloatBall_OnLoaded(object sender, RoutedEventArgs e)
        {
            var workArea = SystemParameters.WorkArea;

            const int offsetTop = 30;
            const int offsetRight = 30;

            Left = workArea.Width - Width - offsetRight;
            Top = workArea.Height - Height - offsetTop;
        }

        private void OnRightClick(object sender, MouseButtonEventArgs e)
        {
            MessageBox.Show("右键点击悬浮球");
        }

        private void OnDoubleClick(object sender, MouseButtonEventArgs e)
        {
            MessageBox.Show("双击悬浮球");
        }

        private void OnMouseDown(object sender, MouseButtonEventArgs e)
        {
            if (e.LeftButton == MouseButtonState.Pressed)
            {
                DragMove();
            }
        }
    }
}

