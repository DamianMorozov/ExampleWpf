using System;
using System.Windows;

namespace WpfLocalizationFromResX
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void dynamicEnglish_Click(object sender, RoutedEventArgs e)
        {
            SetLanguageDictionary(EnumLocalization.English);
        }

        private void dynamicRussian_Click(object sender, RoutedEventArgs e)
        {
            SetLanguageDictionary(EnumLocalization.Russian);
        }

        private void SetLanguageDictionary(EnumLocalization localization)
        {
            Resources.MergedDictionaries.Clear();
            Resources = new ResourceDictionary();
            switch (localization)
            {
                case EnumLocalization.Russian:
                    Resources.Source = new Uri("pack://application:,,,/Resources/LocalizationRussian.xaml");
                    break;
                default:
                    Resources.Source = new Uri("pack://application:,,,/Resources/LocalizationEnglish.xaml");
                    break;
            }
        }
    }
}
