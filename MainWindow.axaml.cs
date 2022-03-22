using Avalonia.Controls;

namespace LinuxCrashMinimalRepro
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            var button = this.FindControl<Button>("mButton");
            button.Click += (sender, e) =>
            {
                var window = new Window();
                window.ShowDialog(this);
            };
        }
    }
}