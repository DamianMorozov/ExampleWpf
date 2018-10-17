using System;
using System.Globalization;
using System.Linq;
using System.Windows;

namespace WpfLocalizationFromResX
{
    public enum Languages { ruRU, enUS }

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

        private void LoadCompleted(object sender, System.Windows.Navigation.NavigationEventArgs e)
        {
            SetLanguage(Properties.Settings.Default.DefaultLanguage);
        }

        /// <summary>
        /// Localization language like Localization
        /// </summary>
        [Obsolete(@"Поле открыто только для поля CultureInfo")]
        private Languages _languageAsLocalization;

#pragma warning disable 0612, 0618
        /// <summary>
        /// Localization language like CultureInfo
        /// </summary>
        private CultureInfo _languageAsCultureInfo
        {
            get
            {
                switch (_languageAsLocalization)
                {
                    case Languages.ruRU:
                        return new CultureInfo("ru-RU");
                    default:
                        return new CultureInfo("en-US");
                }
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
                switch (value.Name.ToUpper())
                {
                    case "RU-RU":
                        _languageAsLocalization = Languages.ruRU;
                        System.Threading.Thread.CurrentThread.CurrentUICulture = new CultureInfo("ru-RU");
                        resourceDictionary.Source = new Uri("pack://application:,,,/Resources/LocalizationRussian.xaml");
                        break;
                    default:
                        _languageAsLocalization = Languages.enUS;
                        System.Threading.Thread.CurrentThread.CurrentUICulture = new CultureInfo("en-US");
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
                Changed?.Invoke(Application.Current, new EventArgs());
            }
        }
#pragma warning restore 0612, 0618

        /// <summary>
        /// Get localization language like CultureInfo
        /// </summary>
        /// <returns></returns>
        public CultureInfo GetLanguageAsCultureInfo()
        {
            switch (_languageAsCultureInfo.Name.ToUpper())
            {
                case "RU-RU":
                    return new CultureInfo("ru-RU");
                default:
                    return new CultureInfo("en-US");
            }
        }

        /// <summary>
        /// Get localization language like Localization
        /// </summary>
        /// <returns></returns>
        public Languages GetLanguageAsLocalization()
        {
            switch (_languageAsCultureInfo.Name.ToUpper())
            {
                case "RU-RU":
                    return Languages.ruRU;
                default:
                    return Languages.enUS;
            }
        }

        /// <summary>
        /// Set localization language
        /// </summary>
        /// <param name="cultureInfo"></param>
        public void SetLanguage(CultureInfo cultureInfo)
        {
            _languageAsCultureInfo = cultureInfo;
        }

        /// <summary>
        /// Set localization language
        /// </summary>
        /// <param name="cultureInfo"></param>
        public void SetLanguage(Languages localization)
        {
            switch (localization)
            {
                case Languages.ruRU:
                    _languageAsCultureInfo = new CultureInfo("ru-RU");
                    break;
                default:
                    _languageAsCultureInfo = new CultureInfo("en-US");
                    break;
            }
        }

        public event EventHandler Changed;

        /// <summary>
        /// Get resource string
        /// </summary>
        public string GetResourceString(string resourceName)
        {
            string result = null;
            ResourceDictionary resourceDictionary = null;
            if (Application.Current.Resources.MergedDictionaries.Count > 0)
                resourceDictionary = (
                    from dict in Application.Current.Resources.MergedDictionaries
                    where dict.Source != null && dict.Source.OriginalString.Contains("Resources/Localization")
                    select dict).First();
            if (resourceDictionary != null)
            {
                int iDict = Application.Current.Resources.MergedDictionaries.IndexOf(resourceDictionary);
                if (Application.Current.Resources.MergedDictionaries[iDict].Contains(resourceName))
                    result = Application.Current.Resources[resourceName].ToString();
            }
            return result;
        }
    }
}
