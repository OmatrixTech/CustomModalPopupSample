using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Media;
using WPF.Custom.PopupDialogs.Utility;

namespace WPFCustomDialogTesting
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        protected override void OnStartup(StartupEventArgs e)
        {
            base.OnStartup(e);
            ModalPopupSetup();
        }

        private void ModalPopupSetup()
        {

            ModalPopupConfigurationSetup.ModalPopupBodyBackgroundColor = new SolidColorBrush(Colors.Black);
            ModalPopupConfigurationSetup.ModalPopupButtonBottomAlignment = HorizontalAlignment.Right;
            ModalPopupConfigurationSetup.ModalPopupButtonWidth = 100.0;
            ModalPopupConfigurationSetup.ModalPopupMessageTextColor = new SolidColorBrush(Colors.White);
            ModalPopupConfigurationSetup.ModalPopupMessageTextFontSize = 15.0;
            ModalPopupConfigurationSetup.ModalPopupButtonDisplayBackgroundColor = new SolidColorBrush(Colors.Blue);
            ModalPopupConfigurationSetup.ModalPopupButtonTextColor = new SolidColorBrush(Colors.White);
            ModalPopupConfigurationSetup.ModalPopupMouseHoveButtonBackgroundColor = new SolidColorBrush(Colors.OrangeRed);
            ModalPopupConfigurationSetup.ModalpopupMouseHoverButtonForegroundColor = new SolidColorBrush(Colors.White);
        }
    }
}
