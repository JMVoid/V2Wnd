using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Globalization;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;

namespace V2Wnd
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        public App() {
            CultureInfo cultureInfo = CultureInfo.CurrentCulture;
            if (cultureInfo != null && cultureInfo.Name.StartsWith("zh-")) {
                cultureInfo = new CultureInfo("en-US");
                Thread.CurrentThread.CurrentUICulture = cultureInfo;
                Thread.CurrentThread.CurrentCulture = cultureInfo;
            }
        }
    }
}
