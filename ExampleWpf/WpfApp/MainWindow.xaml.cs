using System.Windows;
using System.Windows.Controls;

namespace WpfApp
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show(FieldSome.Text);
        }
        private void ButtonCreateNewButton_Click(object sender, RoutedEventArgs e)
        {
            var myButton = new Button
            {
                Width = ButtonCreateNew.Width,
                Height = 23,
                Content = "New button",
                HorizontalAlignment = HorizontalAlignment.Stretch,
                Background = new System.Windows.Media.SolidColorBrush(System.Windows.Media.Colors.Red),
            };
            LayoutGrid.Children.Add(myButton);
        }

    }
}
