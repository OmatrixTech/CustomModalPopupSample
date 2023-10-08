using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Media;
using System.Windows.Media.Imaging;
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
            CustomMessageBoxHandler.GetInstance.ConfigureModalPopupSettings(
             ModalPopupMouseHoverButtonBackgroundColor: new SolidColorBrush(Colors.Green),
             ModalPopupMouseHoverButtonForegroundColor: new SolidColorBrush(Colors.Black),
             ModalPopupBodyBackgroundColor: new SolidColorBrush(Colors.White),
             ModalPopupMessageTextColor: new SolidColorBrush(Colors.Red),
             ModalPopupMessageTextFontSize: 15.0,
             ModalPopupMessageTextFontFamily: new FontFamily("Courier New Bold Italic"),
             ModalPopupButtonBottomAlignment: HorizontalAlignment.Right,
             ModalPopupButtonWidth: 100.0,
             ModalPopupButtonTextColor: new SolidColorBrush(Colors.Blue),
             ModalPopupButtonDisplayBackgroundColor: new SolidColorBrush(Colors.OrangeRed),
             ModalPopupHeaderBackgroundColor: new SolidColorBrush(Colors.Black),
             ModalPopupHeaderTitleTextColor: new SolidColorBrush(Colors.Red),
             ModalPopupHeaderFontFamily: new FontFamily("Times New Roman"),
             ModalPopupHeaderFontSize: 12.0,
             ModalPopupHeaderIcon: CreateImageSourceFromPackUri());
        }
        public ImageSource CreateImageSourceFromPackUri()
        {
            try
            {
                //When image is kept in running assembly
                Uri uri = new Uri(@"pack://application:,,,/WPFCustomDialogTesting;component/Resources/Images/CameraControl.png", UriKind.RelativeOrAbsolute);
                return new BitmapImage(uri);
            }
            catch (Exception ex)
            {
                // Handle any exceptions:"", such as UriFormatException or FileNotFoundException
                // You can log the exception or return a default image source if needed
                return new BitmapImage();
            }
        }

    }
}
