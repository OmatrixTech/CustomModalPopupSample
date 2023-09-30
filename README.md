The objective of developing this project is to facilitate users in implementing customized modal popups in WPF, especially within the MVVM pattern. It offers a straightforward implementation process, allowing users to create modal popups tailored to their project's specific themes and requirements.

Here are the steps to use this project:

1. Installation:
   - Install the NuGet package 'CustomModalPopups' or use the DLL available in the DLL folder.

2. To display the 'CustomConfirmModalPopup' modal popup in MVVM:
   - Use the following code with the required parameters:
     ```csharp
     // I) Show the modal popup
     ModalCustomAlertPopupInstanceHandler.GetInstance.ShowCustomConfirmDialog(
         headerTitle: "Information",
         modalPopupMessageText: "Do you want to close this popup?",
         messageBoxImageIconType: CustomMessageBoxImage.Information,
         modalPopupFirstButtonText: "OK",
         modalPopupSecondButtonText: "Cancel"
     );

     // II) Register the event handler in your constructor to get the dialog result
     CommonEvents.ModalConfirmDialogCallbackHandler += CommonEvents_ModalPopupCallbackHandler;

     private void CommonEvents_ModalPopupCallbackHandler(object sender, ProcessEventArgs e)
     {
         if (e.DialogResult)
         {
             // Perform your task when 'OK' is clicked
         }
         else
         {
             // Perform an action when 'Cancel' is clicked
         }
     }
     ```

3. To display the 'CustomAlertModalPopup' modal popup in MVVM:
   - Use the following code with the required parameters:
     ```csharp
     ModalCustomAlertPopupInstanceHandler.GetInstance.ShowCustomAlertDialog(
         headerTitle: "Information",
         modalPopupMessageText: "This is a custom message box",
         messageBoxImageIconType: CustomMessageBoxImage.Information,
         modalPopupButtonText: "OK"
     );
     ```
   
These steps empower users to easily integrate and utilize custom modal popups in their WPF projects while adhering to the MVVM pattern."
