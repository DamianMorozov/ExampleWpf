using System.Windows;

namespace XamlSwitching
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, RoutedEventArgs e)
        {
            //UserControl1 view1 = new UserControl1();
            //contentControl.DataContext = null;
            //contentControl.DataContext = view1.DataContext;
            if (contentControl.DataContext is MainWindowViewModel dc)
            {
                dc.SwitchView = 1;
            }
        }

        private void Button2_Click(object sender, RoutedEventArgs e)
        {
            //UserControl2 view2 = new UserControl2();
            //contentControl.DataContext = null;
            //contentControl.DataContext = view2.DataContext;
            if (contentControl.DataContext is MainWindowViewModel dc)
            {
                dc.SwitchView = 2;
            }
        }
    }
}
