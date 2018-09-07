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

        private void ButtonCreateNewWindow_Click(object sender, RoutedEventArgs e)
        {
            var windowUniformGrid = new WindowUniformGrid
            {
                Left = Left + Width,
                Top = Top,
            };
            windowUniformGrid.ShowDialog();
        }

        private void ButtonCreateGridSplitter_Click(object sender, RoutedEventArgs e)
        {
            var windowGridSplitter = new WindowGridSplitter
            {
                Left = Left + Width,
                Top = Top,
            };
            windowGridSplitter.ShowDialog();
        }

        private void ButtonCreateStackPanel_Click(object sender, RoutedEventArgs e)
        {
            var windowStackPanel = new WindowStackPanel
            {
                Left = Left + Width,
                Top = Top,
            };
            windowStackPanel.ShowDialog();
        }
    }
}
