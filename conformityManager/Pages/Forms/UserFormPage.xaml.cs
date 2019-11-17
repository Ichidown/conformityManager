using conformityManager.Pages.SubPages;
using conformityManager.Ressources.Structures;
using System;
using System.Windows;
using System.Windows.Controls;

namespace conformityManager.Pages.Forms
{
    public partial class UserFormPage : Page
    {
        UserManagementPage userManagementPage;
        private int currentIndex = -1;
        private User currentUser;
        //private bool isEdit;
        public UserFormPage(UserManagementPage userManagementPage) // New User CONSTRUCTOR
        {
            this.userManagementPage = userManagementPage;
            InitializeComponent();
        }

        public UserFormPage(UserManagementPage userManagementPage, User user) // Edit User CONSTRUCTOR
        {
            this.userManagementPage = userManagementPage;
            this.currentUser = user;


            InitializeComponent();

            this.currentIndex = user.id;
            userNameTxt.Text = user.username;
            fullNameTxt.Text = user.full_name;
            functionTxt.Text = user.function;

            // Change Ui
            ConfirmBtn.Content = "Confirmer modification";
            TitleLabel.Text = "Modifier utilisateur";
        }

        private void ConfirmBtnClick(object sender, RoutedEventArgs e)
        {
            if(currentIndex == -1) // CREATION
            {
                if (userNameTxt.Text.Length > 0 &&
                passwordTxt.Password.Length > 0 &&
                fullNameTxt.Text.Length > 0 &&
                functionTxt.Text.Length > 0)
                {
                    int existResult = userManagementPage.mainWindow.sqlTools.DoesUserExistSQL(userNameTxt.Text, userManagementPage.mainWindow);
                    /*if (result != -1)
                    {*/
                    if (existResult == 0)
                    {
                        // Nullable<User> newuser = userManagementPage.mainWindow.sqlTools.CreateUserSQL(userNameTxt.Text, passwordTxt.Password, fullNameTxt.Text, functionTxt.Text);

                        if (userManagementPage.mainWindow.sqlTools.CreateUserSQL(userNameTxt.Text, passwordTxt.Password, fullNameTxt.Text, functionTxt.Text, userManagementPage.mainWindow))
                        {
                            userManagementPage.RefreshUserList();
                            userManagementPage.NewFormDialog.IsOpen = false;
                            userManagementPage.mainWindow.newSuccessMessageQueue("Creation de l'utilisateur reussie.");
                        }
                    }
                    else if (existResult == 1)
                        userManagementPage.mainWindow.newErrorMessageQueue("Erreur : le nom d'utilisateur existe deja.");
                }
                else
                    userManagementPage.mainWindow.newErrorMessageQueue("Veiller completer tout les champs du formulaire.");
            }

            else // UPDATE
            {
                if (userNameTxt.Text.Length > 0 &&
                fullNameTxt.Text.Length > 0 &&
                functionTxt.Text.Length > 0)
                {
                    int existResult = userManagementPage.mainWindow.sqlTools.DoesUserExistSQL(userNameTxt.Text, userManagementPage.mainWindow);
                    if (existResult == 0 || (existResult == 1 && currentUser.username == userNameTxt.Text)) // if username is new || is the same as the current
                    {
                        if (userManagementPage.mainWindow.sqlTools.UpdateUserSQL(currentIndex, userNameTxt.Text, passwordTxt.Password, fullNameTxt.Text, functionTxt.Text, userManagementPage.mainWindow))
                        {
                            userManagementPage.RefreshUserList();
                            userManagementPage.NewFormDialog.IsOpen = false;
                            userManagementPage.mainWindow.newSuccessMessageQueue("Mise a jour de l'utilisateur avec success.");
                        }
                    }
                    else if (existResult == 1)
                        userManagementPage.mainWindow.newErrorMessageQueue("Erreur : le nom d'utilisateur existe deja.");
                }
                else
                    userManagementPage.mainWindow.newErrorMessageQueue("Veiller completer tout les champs du formulaire.");
            }
            
        }
    }
}
