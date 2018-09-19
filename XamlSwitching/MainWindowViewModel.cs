using PropertyChanged;

namespace XamlSwitching
{
    /// <summary>
    /// ViewModel for MainWindow
    /// </summary>
    [AddINotifyPropertyChangedInterface]
    public class MainWindowViewModel
    {
        public int SwitchView { get; set; } = 1;

        public MainWindowViewModel()
        {
            //
        }
    }
}
