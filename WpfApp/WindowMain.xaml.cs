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
            var window = new WindowUniformGrid
            {
                Left = Left + Width,
                Top = Top,
            };
            window.ShowDialog();
        }

        private void ButtonCreateGridSplitter_Click(object sender, RoutedEventArgs e)
        {
            var window = new WindowGridSplitter
            {
                Left = Left + Width,
                Top = Top,
            };
            window.ShowDialog();
        }

        private void ButtonCreateStackPanel_Click(object sender, RoutedEventArgs e)
        {
            var window = new WindowStackPanel
            {
                Left = Left + Width,
                Top = Top,
            };
            window.ShowDialog();
        }

        private void ButtonCreateDockPanel_Click(object sender, RoutedEventArgs e)
        {
            var window = new WindowDockPanel
            {
                Left = Left + Width,
                Top = Top,
            };
            window.ShowDialog();
        }

        private void ButtonCreateWrapPanel_Click(object sender, RoutedEventArgs e)
        {
            var window = new WindowWrapPanel
            {
                Left = Left + Width,
                Top = Top,
            };
            window.ShowDialog();
        }

        private void ButtonCreateCanvas_Click(object sender, RoutedEventArgs e)
        {
            var window = new WindowCanvas
            {
                Left = Left + Width,
                Top = Top,
            };
            window.ShowDialog();
        }
    }
}
