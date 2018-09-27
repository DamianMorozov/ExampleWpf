using System.Windows;

namespace XamlSwitching
{
    /// <summary>
    /// Logic of interaction for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, RoutedEventArgs e)
        {
            if (contentControl.DataContext is MainWindowViewModel dataContext)
            {
                dataContext.SwitchView = 1;
            }
        }

        private void Button2_Click(object sender, RoutedEventArgs e)
        {
            if (contentControl.DataContext is MainWindowViewModel dataContext)
            {
                dataContext.SwitchView = 2;
            }
        }

        private void Button3_Click(object sender, RoutedEventArgs e)
        {
            if (contentControl.DataContext is MainWindowViewModel dataContext)
            {
                dataContext.SwitchView = 3;
            }
        }
    }
}
