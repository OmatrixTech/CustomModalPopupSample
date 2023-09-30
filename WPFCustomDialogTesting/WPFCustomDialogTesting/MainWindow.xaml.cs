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
            CommonEvents.ModalConfirmDialogCallbackHandler += CommonEvents_ModalPopupCallbackHandler;
        }

        private void CommonEvents_ModalPopupCallbackHandler(object sender, ProcessEventArgs e)
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
            ModalCustomAlertPopupInstanceHandler.GetInstance.ShowCustomAlertDialog(headerTitle:"Information",modalPopupMessageText:"This is a custom message box",messageBoxImageIconType:CustomMessageBoxImage.Information, modalPopupButtonText:"OK");
            
        }

        private void BtnConfirm_Click(object sender, RoutedEventArgs e)
        {
            ModalCustomAlertPopupInstanceHandler.GetInstance.ShowCustomCustomConfirmDialog(headerTitle: "Information", modalPopupMessageText: "Do you want to close this popup?", messageBoxImageIconType: CustomMessageBoxImage.Information, modalPopupFirstButtonText: "OK", modalPopupSecondButtonText: "Cancel");
        }
    }
}
