﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WpfLocalizationFromResX.Properties {
    using System;
    
    
    /// <summary>
    ///   A strongly-typed resource class, for looking up localized strings, etc.
    /// </summary>
    // This class was auto-generated by the StronglyTypedResourceBuilder
    // class via a tool like ResGen or Visual Studio.
    // To add or remove a member, edit your .ResX file then rerun ResGen
    // with the /str option, or rebuild your VS project.
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "16.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    internal class Resources {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal Resources() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("WpfLocalizationFromResX.Properties.Resources", typeof(Resources).Assembly);
                    resourceMan = temp;
                }
                return resourceMan;
            }
        }
        
        /// <summary>
        ///   Overrides the current thread's CurrentUICulture property for all
        ///   resource lookups using this strongly typed resource class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Globalization.CultureInfo Culture {
            get {
                return resourceCulture;
            }
            set {
                resourceCulture = value;
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to &lt;ResourceDictionary 
        ///    xmlns=&quot;http://schemas.microsoft.com/winfx/2006/xaml/presentation&quot;
        ///    xmlns:x=&quot;http://schemas.microsoft.com/winfx/2006/xaml&quot;&gt;
        ///    &lt;!-- Colors --&gt;
        ///    &lt;SolidColorBrush x:Key=&quot;colorRedStyle&quot; Color=&quot;Red&quot; /&gt;
        ///    &lt;LinearGradientBrush x:Key=&quot;colorLightBlueWhite&quot; StartPoint=&quot;0.7,1&quot; EndPoint=&quot;1,0&quot;&gt;
        ///        &lt;GradientStop Color=&quot;LightBlue&quot; Offset=&quot;0&quot; /&gt;
        ///        &lt;GradientStop Color=&quot;White&quot; Offset=&quot;1&quot; /&gt;
        ///    &lt;/LinearGradientBrush&gt;
        ///    &lt;LinearGradientBrush x:Key=&quot;colorBrushWhiteBlue&quot;&gt;
        /// [rest of string was truncated]&quot;;.
        /// </summary>
        internal static string DictionaryColors {
            get {
                return ResourceManager.GetString("DictionaryColors", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to &lt;ResourceDictionary 
        ///    xmlns=&quot;http://schemas.microsoft.com/winfx/2006/xaml/presentation&quot;
        ///    xmlns:x=&quot;http://schemas.microsoft.com/winfx/2006/xaml&quot;
        ///    xmlns:system=&quot;clr-namespace:System;assembly=mscorlib&quot;&gt;
        ///    &lt;!-- English localization --&gt;
        ///    &lt;system:String x:Key=&quot;textAppTitle&quot;&gt;Example WPF resources&lt;/system:String&gt;
        ///    &lt;system:String x:Key=&quot;textResource&quot;&gt;Resources&lt;/system:String&gt;
        ///    &lt;system:String x:Key=&quot;textAddResource&quot;&gt;Add color resource&lt;/system:String&gt;
        ///    &lt;system:String x:Key=&quot;textSetResour [rest of string was truncated]&quot;;.
        /// </summary>
        internal static string LocalizationEnglish {
            get {
                return ResourceManager.GetString("LocalizationEnglish", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to &lt;ResourceDictionary
        ///    xmlns=&quot;http://schemas.microsoft.com/winfx/2006/xaml/presentation&quot;
        ///    xmlns:x=&quot;http://schemas.microsoft.com/winfx/2006/xaml&quot;
        ///    xmlns:system=&quot;clr-namespace:System;assembly=mscorlib&quot;&gt;
        ///    &lt;!-- Русская локализация --&gt;
        ///    &lt;system:String x:Key=&quot;textAppTitle&quot;&gt;Пример ресурсов WPF&lt;/system:String&gt;
        ///    &lt;system:String x:Key=&quot;textResource&quot;&gt;Ресурсы&lt;/system:String&gt;
        ///    &lt;system:String x:Key=&quot;textAddResource&quot;&gt;Добавить ресурс цвета&lt;/system:String&gt;
        ///    &lt;system:String x:Key=&quot;textSetResource&quot; [rest of string was truncated]&quot;;.
        /// </summary>
        internal static string LocalizationRussian {
            get {
                return ResourceManager.GetString("LocalizationRussian", resourceCulture);
            }
        }
    }
}
