using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using V2Wnd.View;

namespace V2Wnd
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        UserControl _generalSetting;
        UserControl _proxiesSetting;
        UserControl _routingRuleSetting;
        UserControl _logMessage;
        UserControl _helperPage;
        public MainWindow()
        {
            InitializeComponent();
            _generalSetting = new GeneralSetting();
            _proxiesSetting = new ProxiesSetting();
            MainContent.Content = _generalSetting;
        }

        private void General_Button_Click(object sender, RoutedEventArgs e)
        {
            MainContent.Content = _generalSetting;
        }

        private void Proxies_Button_Click(object sender, RoutedEventArgs e)
        {
            MainContent.Content = _proxiesSetting;
        }


        private void Log_Button_Click(object sender, RoutedEventArgs e)
        {
          
        }
    }
}
