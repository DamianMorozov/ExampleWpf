using System;
using System.Globalization;
using System.Windows;
using System.Windows.Media;

namespace WpfLocalizationFromResX
{
    public partial class MainWindow : Window
    {
        private SingletonLocalization localization = SingletonLocalization.Instance;

        public MainWindow()
        {
            InitializeComponent();
        }

        private void dynamicEnglish_Click(object sender, RoutedEventArgs e)
        {
            localization.SetLanguage(Languages.enUS);
        }

        private void dynamicRussian_Click(object sender, RoutedEventArgs e)
        {
            localization.SetLanguage(Languages.ruRU);
        }

        private void buttonAddResources_Click(object sender, RoutedEventArgs e)
        {
            // resource
            var colorBrush = new LinearGradientBrush();
            colorBrush.GradientStops.Add(new GradientStop(Colors.Yellow, 0));
            colorBrush.GradientStops.Add(new GradientStop(Colors.Red, 1));

            // add resource
            if (!Resources.Contains("resourceColorBrush"))
                Resources.Add("resourceColorBrush", colorBrush);

            // set resource
            if (TryFindResource("resourceColorBrush") is Brush getColor)
                textBlockResources.Background = getColor;
        }

        private void buttonGetResource_Click(object sender, RoutedEventArgs e)
        {
            textBlockResources.Text = localization.GetResourceString("textGetSomeResult");
        }
    }
}
