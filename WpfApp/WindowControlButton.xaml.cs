using System.Windows;

namespace WpfApp
{
    /// <summary>
    /// Interaction logic for WindowControlButton.xaml
    /// </summary>
    public partial class WindowControlButton : Window
    {
        private uint Count { get; set; } = 0;

        public WindowControlButton()
        {
            InitializeComponent();
        }

        private void ButtonAccept_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Enter was pressed.");
        }

        private void ButtonEsc_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Escape was pressed.");
        }

        private void RepeatButton_Click(object sender, RoutedEventArgs e)
        {
            Count++;
            textBlockOut.Text = System.Convert.ToString(Count);
        }

        private void ToggleButton_Click(object sender, RoutedEventArgs e)
        {
            toggleButton.Content = "toggleButton.IsChecked = " + 
                (toggleButton.IsChecked == null
                ? "<null>" : System.Convert.ToString(toggleButton.IsChecked));
        }
    }
}
