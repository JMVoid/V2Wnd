using System;
using System.Collections.Generic;
using System.Linq;
using System.Resources;
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

namespace V2Wnd.View
{
    /// <summary>
    /// Interaction logic for GeneralSetting.xaml
    /// </summary>
    public partial class GeneralSetting : UserControl
    {

        public GeneralSetting()
        {
            InitializeComponent();
            //TextBoxCard httpPortSetting = new TextBoxCard();
            //httpPortSetting.LabelText.Text = V2Wnd.Resource.MainWindow.HttpPortSetting;
            //httpPortSetting.TextValue.Text = "10.0.0.1";
            this.HttpPort.Content = buildTextBoxCard(V2Wnd.Resource.MainWindow.HttpPort, "10888");
            this.SocksPort.Content = buildTextBoxCard(V2Wnd.Resource.MainWindow.SocksPort, "10889");
            this.AllowLAN.Content = buildToggleCard(V2Wnd.Resource.MainWindow.AllowLAN);
            this.LogLevel.Content = buildDropListCard(V2Wnd.Resource.MainWindow.LogLevel);
            this.StartWithBoot.Content = buildToggleCard(V2Wnd.Resource.MainWindow.StartWithStartup);
            //this.AllowLAN.Content = buildToggleCard();
            //this.AllowLAN.Content = buildToggleCard(V2Wnd.Resource.MainWindow.)
           
        }

        private TextBoxCard buildTextBoxCard(string label, string text) {
            TextBoxCard textBoxCard = new TextBoxCard();
            textBoxCard.LabelText.Text = label;
            textBoxCard.TextValue.Text = text;
            return textBoxCard;
        }
        private ToggleCard buildToggleCard(string label) {
            ToggleCard toggleCard = new ToggleCard();
            toggleCard.LabelText.Text = label;
            return toggleCard;
        }

        private DropListCard buildDropListCard(string label) {
            DropListCard dropListCard = new DropListCard();
            dropListCard.LabelText.Text = label;
            return dropListCard;
        }

    }
}
