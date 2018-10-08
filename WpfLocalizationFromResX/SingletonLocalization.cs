using System;
using System.Globalization;
using System.Linq;
using System.Windows;

namespace WpfLocalizationFromResX
{
    public enum Localization { English, Russian }

    public sealed class SingletonLocalization
    {
        #region Pattern Singleton Lazy<Class>

        private static readonly Lazy<SingletonLocalization> _instance = new Lazy<SingletonLocalization>(() => new SingletonLocalization());

        public static SingletonLocalization Instance { get { return _instance.Value; } }

        private SingletonLocalization()
        {
            LoadCompleted(Application.Current, null);
        }

        #endregion

        public CultureInfo Language
        {
            get
            {
                return System.Threading.Thread.CurrentThread.CurrentUICulture;
            }
            set
            {
                // Checking
                if (value == null) throw new ArgumentNullException("value");
                if (value == System.Threading.Thread.CurrentThread.CurrentUICulture) return;

                // Change language
                System.Threading.Thread.CurrentThread.CurrentUICulture = value;

                // Create ResourceDictionary for new CultureInfo
                var resourceDictionary = new ResourceDictionary();
                switch (value.Name)
                {
                    case "ru-RU":
                        resourceDictionary.Source = new Uri("pack://application:,,,/Resources/LocalizationRussian.xaml");
                        break;
                    default:
                        resourceDictionary.Source = new Uri("pack://application:,,,/Resources/LocalizationEnglish.xaml");
                        break;
                }

                // Change ResourceDictionary
                ResourceDictionary oldDictionary = null;
                if (Application.Current.Resources.MergedDictionaries.Count > 0)
                    oldDictionary = (
                        from dict in Application.Current.Resources.MergedDictionaries
                        where dict.Source != null && dict.Source.OriginalString.Contains("Resources/Localization")
                        select dict).First();
                if (oldDictionary != null)
                {
                    int iDict = Application.Current.Resources.MergedDictionaries.IndexOf(oldDictionary);
                    Application.Current.Resources.MergedDictionaries.Remove(oldDictionary);
                    Application.Current.Resources.MergedDictionaries.Insert(iDict, resourceDictionary);
                }
                else
                {
                    Application.Current.Resources.MergedDictionaries.Add(resourceDictionary);
                }

                // Event
                LanguageChanged(Application.Current, new EventArgs());
            }
        }

        public void SetLanguage(Localization language)
        {
            switch (language)
            {
                case Localization.English:
                    Language = new CultureInfo("en-US");
                    break;
                case Localization.Russian:
                    Language = new CultureInfo("ru-RU");
                    break;
            }
        }

        private void LoadCompleted(object sender, System.Windows.Navigation.NavigationEventArgs e)
        {
            Language = Properties.Settings.Default.DefaultLanguage;
        }

        private void LanguageChanged(Object sender, EventArgs e)
        {
            Properties.Settings.Default.DefaultLanguage = Language;
            Properties.Settings.Default.Save();
        }

    }
}
