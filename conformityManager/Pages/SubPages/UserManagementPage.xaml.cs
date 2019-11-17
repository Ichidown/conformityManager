using conformityManager.Pages.Forms;
using conformityManager.Ressources.Interfaces;
using conformityManager.Ressources.Structures;
using System;
using System.Collections.Generic;
using System.Windows;
using System.Windows.Controls;

namespace conformityManager.Pages.SubPages
{

    public partial class UserManagementPage : Page, SubPageInterface
    {
        public MainWindow mainWindow;
        public int focussedRow;
        UserFormPage userFormPage;
        public List<User> userList; // = new List<User>();

        public UserManagementPage(MainWindow mainWindow)
        {
            this.mainWindow = mainWindow;
            InitializeComponent();
            
            RefreshUserList();
            
        }




        public void RefreshUserList()
        {
            /*this.Dispatcher.Invoke(() =>
            {
                userList = mainWindow.sqlTools.GetUserListSQL();
                UserDataGrid.ItemsSource = userList;
            });*/
            
            userList = mainWindow.sqlTools.GetUserListSQL(mainWindow);
            UserDataGrid.ItemsSource = userList;
            
        }
        
        private void ShowNewUserForm(object sender, RoutedEventArgs e)
        {
            userFormPage = new UserFormPage(this);
            UserFormFrame.Content = userFormPage;
            NewFormDialog.IsOpen = true;
        }

        private void UpdateUserInput(object sender, RoutedEventArgs e)
        {
            focussedRow = UserDataGrid.SelectedIndex;
            userFormPage = new UserFormPage(this, userList[focussedRow]);
            UserFormFrame.Content = userFormPage;
            NewFormDialog.IsOpen = true;
        }

        private void RemoveUserInput(object sender, RoutedEventArgs e)
        {
            focussedRow = UserDataGrid.SelectedIndex;
            DeleateDialog.IsOpen = true;
        }

        private void ConfirmRemoveUserInput(object sender, RoutedEventArgs e)
        {
            if (mainWindow.sqlTools.RemoveUserSQL(userList[UserDataGrid.SelectedIndex].id, mainWindow))
            {
                mainWindow.newSuccessMessageQueue("Supression de l'utilisateur avec success.");
                RefreshUserList();
            }
        }

        public void QuitPage()
        {
            NewFormDialog.IsOpen = false;
            DeleateDialog.IsOpen = false;
        }
    }
}
