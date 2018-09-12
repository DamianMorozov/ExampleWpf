using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;

namespace WpfApp
{
    /// <summary>
    /// Interaction logic for WindowBinding.xaml
    /// </summary>
    public partial class WindowBindingControl : Window
    {
        public WindowBindingControl()
        {
            InitializeComponent();
        }

        private void ButtonSetBindToTextBox1_Click(object sender, RoutedEventArgs e)
        {
            var binding = new Binding
            {
                ElementName = "textBox1",
                Path = new PropertyPath("Text"),
                IsAsync = true,
                TargetNullValue = "<source binding is null>",
                Mode=BindingMode.TwoWay,
                UpdateSourceTrigger = UpdateSourceTrigger.PropertyChanged,
            };
            textBlock.SetBinding(TextBlock.TextProperty, binding);
        }

        private void ButtonSetBindToTextBox2_Click(object sender, RoutedEventArgs e)
        {
            var binding = new Binding
            {
                ElementName = "textBox2",
                Path = new PropertyPath("Text"),
                IsAsync = true,
                TargetNullValue = "<source binding is null>",
                Mode = BindingMode.TwoWay,
                UpdateSourceTrigger = UpdateSourceTrigger.PropertyChanged,
            };
            textBlock.SetBinding(TextBlock.TextProperty, binding);
        }

        private void ButtonClearOneBind_Click(object sender, RoutedEventArgs e)
        {
            BindingOperations.ClearBinding(textBlock, TextBlock.TextProperty);
        }

        private void ButtonClearAllBinds_Click(object sender, RoutedEventArgs e)
        {
            BindingOperations.ClearAllBindings(textBlock);
        }
    }
}
