using System.Windows;

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

        private void CreateWindow(WindowType windowType)
        {
            Window window = null;
            switch (windowType)
            {
                case WindowType.WindowClass:
                    window = new WindowClass();
                    break;
                case WindowType.WindowStaticResource:
                    window = new WindowStaticResource();
                    break;
                case WindowType.WindowCanvas:
                    window = new WindowCanvas();
                    break;
                case WindowType.WindowDockPanel:
                    window = new WindowDockPanel();
                    break;
                case WindowType.WindowGridSplitter:
                    window = new WindowGridSplitter();
                    break;
                case WindowType.WindowStackPanel:
                    window = new WindowStackPanel();
                    break;
                case WindowType.WindowUniformGrid:
                    window = new WindowUniformGrid();
                    break;
                case WindowType.WindowWrapPanel:
                    window = new WindowWrapPanel();
                    break;
                case WindowType.WindowBindingControl:
                    window = new WindowBindingControl();
                    break;
                case WindowType.WindowBindingSource:
                    window = new WindowBindingSource();
                    break;
                case WindowType.WindowControlButton:
                    window = new WindowControlButton();
                    break;
            }
            window.Left = Left + Width;
            window.Top = Top;
            window.ShowDialog();
        }

        private void ButtonClass_Click(object sender, RoutedEventArgs e)
        {
            CreateWindow(WindowType.WindowClass);
        }

        private void ButtonStaticResource_Click(object sender, RoutedEventArgs e)
        {
            CreateWindow(WindowType.WindowStaticResource);
        }

        private void ButtonCreateUniformGrid_Click(object sender, RoutedEventArgs e)
        {
            CreateWindow(WindowType.WindowUniformGrid);
        }

        private void ButtonCreateGridSplitter_Click(object sender, RoutedEventArgs e)
        {
            CreateWindow(WindowType.WindowGridSplitter);
        }

        private void ButtonCreateStackPanel_Click(object sender, RoutedEventArgs e)
        {
            CreateWindow(WindowType.WindowStackPanel);
        }

        private void ButtonCreateDockPanel_Click(object sender, RoutedEventArgs e)
        {
            CreateWindow(WindowType.WindowDockPanel);
        }

        private void ButtonCreateWrapPanel_Click(object sender, RoutedEventArgs e)
        {
            CreateWindow(WindowType.WindowWrapPanel);
        }

        private void ButtonCreateCanvas_Click(object sender, RoutedEventArgs e)
        {
            CreateWindow(WindowType.WindowCanvas);
        }

        private void ButtonCreateBindingControl_Click(object sender, RoutedEventArgs e)
        {
            CreateWindow(WindowType.WindowBindingControl);
        }

        private void ButtonCreateBindingSource_Click(object sender, RoutedEventArgs e)
        {
            CreateWindow(WindowType.WindowBindingSource);
        }

        private void ButtonCreateControlButton_Click(object sender, RoutedEventArgs e)
        {
            CreateWindow(WindowType.WindowControlButton);
        }
    }

    public enum WindowType
    {
        WindowClass,
        WindowStaticResource,
        WindowCanvas,
        WindowDockPanel,
        WindowGridSplitter,
        WindowStackPanel,
        WindowUniformGrid,
        WindowWrapPanel,
        WindowBindingControl,
        WindowBindingSource,
        WindowControlButton,
    }
}
