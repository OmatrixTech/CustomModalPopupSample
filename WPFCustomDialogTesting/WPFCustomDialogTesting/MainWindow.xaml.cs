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
using WPF.Custom.PopupDialogs.Utility;

namespace WPFCustomDialogTesting
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            SharedOccurrenceEventsHandler.ModalConfirmDialogCallBackHandler += CommonEvents_ModalConfirmDialogCallBackHandler;
        }

        private void CommonEvents_ModalConfirmDialogCallBackHandler(object sender, ProcessEventArgs e)
        {
            if (e.DialogResult)
            {
                //Perform your task
            }
            else
            {
                //do action
            }
        }

        private void BtnAlert_Click(object sender, RoutedEventArgs e)
        {
            CustomMessageBoxHandler.GetInstance.DisplayCustomAlertMessageBox(headerTitle: "Information", modalPopupMessageText: "This is a custom message box", messageBoxImageIconType: CustomMessageBoxImage.Exclamation, modalPopupButtonText: "OK");
        }

        private void BtnConfirm_Click(object sender, RoutedEventArgs e)
        {
            CustomMessageBoxHandler.GetInstance.DisplayCustomConfirmationMessageBox(headerTitle: "Information", modalPopupMessageText: "Do you want to close this popup?Do you want to close this popup?Do you want to close this popup?", messageBoxImageIconType: CustomMessageBoxImage.Error, modalPopupFirstButtonText: "OK", modalPopupSecondButtonText: "Cancel");
        }

        private void BtnComprehensiveAlertPopup_Click(object sender, RoutedEventArgs e)
        {
            CustomMessageBoxHandler.GetInstance.DisplayComprehensiveCustomAlertMessageBox(headerTitle: "Information", modalPopupMessageText: "You can rewrite \"CommonEvents\" as \"SharedOccurrences\" or \"UniversalOccurrences\" depending on the context and specific meaning you want to convey.", messageBoxImageIconType: CustomMessageBoxImage.Question, modalPopupButtonText: "Okay");
        }

        private void BtnComprehensiveConfirmModalPopup_Click(object sender, RoutedEventArgs e)
        {
            CustomMessageBoxHandler.GetInstance.DisplayComprehensiveCustomConfirmMessageBox(headerTitle: "Message", modalPopupMessageText: "You can rewrite \"CommonEvents\" as \"SharedOccurrences\" or \"UniversalOccurrences\" depending on the context and specific meaning you want to convey.", messageBoxImageIconType: CustomMessageBoxImage.Hand, modalPopupFirstButtonText: "Okay", modalPopupSecondButtonText: "Close");
        }
    }
}
